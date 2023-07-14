using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SANBAY
{
    public partial class frmLai : DevExpress.XtraEditors.XtraForm
    {
        public frmLai()
        {
            InitializeComponent();
        }

        private void frmLai_Load(object sender, EventArgs e)
        {
            dSSB.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSSB.LAI' table. You can move, or remove it, as needed.
            this.lAITableAdapter.Fill(this.dSSB.LAI);
            // TODO: This line of code loads data into the 'dSSB.SP_DANHSACH_LAI' table. You can move, or remove it, as needed.
            this.sP_DANHSACH_LAITableAdapter.Fill(this.dSSB.SP_DANHSACH_LAI);

            LayLOAI("SELECT * FROM V_MALOAI_TENLOAI");
            LayPHICONG("SELECT * FROM V_HOTEN_CMND_PHICONG");
            lAIBindingSource.AddNew();

            phanQuyen();
        }

        private void phanQuyen()
        {
            if (Program.Nhom.Trim() == "PHICONG")
            {
                btnHuyLai.Enabled = btnChiDinh.Enabled = false;
            }
            else if (Program.Nhom.Trim() == "NHANVIEN")
            {
                btnHuyLai.Enabled = btnChiDinh.Enabled = false;
            }
            else
            {
                btnHuyLai.Enabled = btnChiDinh.Enabled = true;
            }
        }
        public void LayPHICONG(String cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            cbxPhiCong.DataSource = dt;
            cbxPhiCong.DisplayMember = "HOTEN"; cbxPhiCong.ValueMember = "CMND";
            cbxPhiCong.SelectedIndex = 1; cbxPhiCong.SelectedIndex = 0;
        }

        public void LayLOAI(String cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            cbxLoai.DataSource = dt;
            cbxLoai.DisplayMember = "TENLOAI"; cbxLoai.ValueMember = "MALOAI";
            cbxLoai.SelectedIndex = 1; cbxLoai.SelectedIndex = 0;
        }

        public void ExecSP(String strLenh)
        {

            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show("Lỗi exec SP \n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private bool CheckCMND_MALOAI()
        {
            // Kiểm tra trùng mã CMND
            string query1 = "DECLARE  @return int "
                    + "EXEC @return = SP_CHECK_CMND_MALOAI @CMND = '" + txtCMND.Text.Trim() + "' " + ", @MALOAI = "+txtMaLoai.Text.Trim()+" "
                    + "SELECT  'Return Value' = @return";
            int resultMa = Program.CheckDataHelper(query1);
            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (resultMa == 1)
            {
                MessageBox.Show("Phi công đang được chỉ định lái loại này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void cbxPhiCong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCMND.Text = cbxPhiCong.SelectedValue.ToString();
        }

        private void cbxLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaLoai.Text = cbxLoai.SelectedValue.ToString();
        }

        private void btnChiDinh_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text.Trim() == "" || txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckCMND_MALOAI())
            {
                if (MessageBox.Show("Ngài có thực sự muốn chỉ định phi công lái ?",
                        "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    try
                    {
                        this.lAIBindingSource.EndEdit();
                        this.lAIBindingSource.ResetCurrentItem();
                        this.lAITableAdapter.Update(this.dSSB.LAI);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi lái!!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    this.sP_DANHSACH_LAITableAdapter.Fill(this.dSSB.SP_DANHSACH_LAI);
                    this.sP_DANHSACH_LAITableAdapter.Fill(this.dSSB.SP_DANHSACH_LAI);
                    MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.lAIBindingSource.AddNew();
                }
            }
        }

        private void btnHuyLai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ngài có thực sự muốn hủy phi công lái loại máy bay này này?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    String cmnd = ((DataRowView)sP_DANHSACH_LAIBindingSource[sP_DANHSACH_LAIBindingSource.Position])["CMND"].ToString();
                    String maloai = ((DataRowView)sP_DANHSACH_LAIBindingSource[sP_DANHSACH_LAIBindingSource.Position])["MALOAI"].ToString();
                    ExecSP("EXEC SP_XOA_LAI '" + cmnd + "', " + maloai + "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa của hệ thống. Hãy xóa lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.sP_DANHSACH_LAITableAdapter.Fill(this.dSSB.SP_DANHSACH_LAI);
                    return;
                }

                this.sP_DANHSACH_LAITableAdapter.Fill(this.dSSB.SP_DANHSACH_LAI);
                MessageBox.Show("Hủy lái thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}