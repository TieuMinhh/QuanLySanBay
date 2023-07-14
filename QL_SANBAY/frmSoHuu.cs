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
    public partial class frmSoHuu : DevExpress.XtraEditors.XtraForm
    {
        public frmSoHuu()
        {
            InitializeComponent();
        }

        private void frmSoHuu_Load(object sender, EventArgs e)
        {
            dSSB.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSSB.SP_SOHUU_DOANHNGHIEP' table. You can move, or remove it, as needed.
            this.sP_SOHUU_DOANHNGHIEPTableAdapter.Fill(this.dSSB.SP_SOHUU_DOANHNGHIEP);
            // TODO: This line of code loads data into the 'dSSB.SP_SOHUU_NGUOI' table. You can move, or remove it, as needed.
            this.sP_SOHUU_NGUOITableAdapter.Fill(this.dSSB.SP_SOHUU_NGUOI);

            
            // TODO: This line of code loads data into the 'dSSB.SOHUU' table. You can move, or remove it, as needed.
            this.sOHUUTableAdapter.Fill(this.dSSB.SOHUU);
            // TODO: This line of code loads data into the 'dSSB.SP_SOHUU_DOANHNGHIEP' table. You can move, or remove it, as needed.
            this.sP_SOHUU_DOANHNGHIEPTableAdapter.Fill(this.dSSB.SP_SOHUU_DOANHNGHIEP);
            // TODO: This line of code loads data into the 'dSSB.SP_SOHUU_NGUOI' table. You can move, or remove it, as needed.
            this.sP_SOHUU_NGUOITableAdapter.Fill(this.dSSB.SP_SOHUU_NGUOI);
            

            LayHOTEN("SELECT * FROM V_HOTEN_ID_CHU");
            LayTENDN("SELECT * FROM V_TENDN_ID_CHU");
            LayTENMAYBAY("SELECT * FROM V_TENMAYBAY_MADK");

            this.sOHUUBindingSource.AddNew();

            phanQuyen();
        }

        private void phanQuyen()
        {
            if (Program.Nhom.Trim() == "PHICONG")
            {
                btnSoHuu.Enabled = btnHuyDN.Enabled = btnHuyNguoi.Enabled = panelControl5.Enabled  = false;
            }
            else if (Program.Nhom.Trim() == "NHANVIEN")
            {
                btnSoHuu.Enabled = btnHuyDN.Enabled = btnHuyNguoi.Enabled = panelControl5.Enabled = false;
            }
            else
            {
                btnSoHuu.Enabled = btnHuyDN.Enabled = btnHuyNguoi.Enabled = panelControl5.Enabled = true;
            }
        }

        public void LayHOTEN(String cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            cbxNguoi.DataSource = dt;
            cbxNguoi.DisplayMember = "TEN"; cbxNguoi.ValueMember = "ID";
            cbxNguoi.SelectedIndex = 1; cbxNguoi.SelectedIndex = 0;
        }

        public void LayTENDN(String cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            cbxDN.DataSource = dt;
            cbxDN.DisplayMember = "TEN"; cbxDN.ValueMember = "ID";
            cbxDN.SelectedIndex = 1; cbxDN.SelectedIndex = 0;
        }

        public void LayTENMAYBAY(String cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            cbxMayBay.DataSource = dt;
            cbxMayBay.DisplayMember = "TEN"; cbxMayBay.ValueMember = "MADANGKY";
            cbxMayBay.SelectedIndex = 1; cbxMayBay.SelectedIndex = 0;
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

        private void cbDoanhNghiep_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDoanhNghiep.Checked)
            {
                cbxNguoi.Enabled = false;
                cbxDN.Enabled = true;
                txtIdChu.Text = cbxDN.SelectedValue.ToString();
            }
            else
            {
                cbxNguoi.Enabled = true;
                cbxDN.Enabled = false;
                txtIdChu.Text = cbxNguoi.SelectedValue.ToString();
            }
        }



        private void cbxMayBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaDK.Text = cbxMayBay.SelectedValue.ToString();
        }

        private void cbxDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoanhNghiep.Checked)
                txtIdChu.Text = cbxDN.SelectedValue.ToString();
        }

        private void cbxNguoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbDoanhNghiep.Checked)
                txtIdChu.Text = cbxNguoi.SelectedValue.ToString();
        }

        private void btnSoHuu_Click(object sender, EventArgs e)
        {
            if (txtIdChu.Text.Trim() == "" || txtMaDK.Text.Trim() == "" || txtNgay.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Ngài có thực sự muốn đăng ký sở hữu ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    this.sOHUUBindingSource.EndEdit();
                    this.sOHUUBindingSource.ResetCurrentItem();
                    this.sOHUUTableAdapter.Update(this.dSSB.SOHUU);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sở hữu!!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.sP_SOHUU_NGUOITableAdapter.Fill(this.dSSB.SP_SOHUU_NGUOI);
                this.sP_SOHUU_DOANHNGHIEPTableAdapter.Fill(this.dSSB.SP_SOHUU_DOANHNGHIEP);
                MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.sOHUUBindingSource.AddNew();
            }
        }

        private void btnHuyNguoi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn hủy sở hữu máy bay của người này?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    String id = ((DataRowView)sP_SOHUU_NGUOIBindingSource[sP_SOHUU_NGUOIBindingSource.Position])["IDCHU"].ToString();
                    String madk = ((DataRowView)sP_SOHUU_NGUOIBindingSource[sP_SOHUU_NGUOIBindingSource.Position])["MADANGKY"].ToString();
                    ExecSP("EXEC SP_XOA_SOHUU " + id + ", " + madk + "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa của hệ thống. Hãy xóa lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.sP_SOHUU_NGUOITableAdapter.Fill(this.dSSB.SP_SOHUU_NGUOI);
                    return;
                }

                this.sP_SOHUU_NGUOITableAdapter.Fill(this.dSSB.SP_SOHUU_NGUOI);
                MessageBox.Show("Hủy sở hữu thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuyDN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ngài có thực sự muốn hủy sở hữu máy bay của doanh nghiệp này?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    String id = ((DataRowView)sP_SOHUU_DOANHNGHIEPBindingSource[sP_SOHUU_DOANHNGHIEPBindingSource.Position])["IDCHU"].ToString();
                    String madk = ((DataRowView)sP_SOHUU_DOANHNGHIEPBindingSource[sP_SOHUU_DOANHNGHIEPBindingSource.Position])["MADANGKY"].ToString();
                    ExecSP("EXEC SP_XOA_SOHUU "+id+", "+madk+"");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa của hệ thống. Hãy xóa lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.sP_SOHUU_DOANHNGHIEPTableAdapter.Fill(this.dSSB.SP_SOHUU_DOANHNGHIEP);
                    return;
                }

                this.sP_SOHUU_DOANHNGHIEPTableAdapter.Fill(this.dSSB.SP_SOHUU_DOANHNGHIEP);
                MessageBox.Show("Hủy sở hữu thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}