using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SANBAY
{
    public partial class frmPhiCong : DevExpress.XtraEditors.XtraForm
    {
        private String hanhDong = "";
        public frmPhiCong()
        {
            InitializeComponent();
        }

        private void frmPhiCong_Load(object sender, EventArgs e)
        {
            dSSB.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSSB.LAI' table. You can move, or remove it, as needed.
            this.lAITableAdapter.Fill(this.dSSB.LAI);
            // TODO: This line of code loads data into the 'dSSB.SP_DANHSACH_PHICONG' table. You can move, or remove it, as needed.
            this.sP_DANHSACH_PHICONGTableAdapter.Fill(this.dSSB.SP_DANHSACH_PHICONG);

            phanQuyen();
        }

        private void phanQuyen()
        {
            if (Program.Nhom.Trim() == "PHICONG")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            }
            else if (Program.Nhom.Trim() == "NHANVIEN")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            }
            else
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            }
        }
        private void enableButton(bool b)
        {
            btnGhi.Enabled = btnHuy.Enabled = panelControl2.Enabled = b;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = !b;
            panelControl1.Enabled = !b;
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
                MessageBox.Show("Lỗi exec SP \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        /*private bool CheckCMND()
        {
            // Kiểm tra trùng mã CMND
            string query1 = "DECLARE  @return int "
                    + "EXEC @return = SP_CHECK_CMND @CMND = '"+txtCMND.Text.Trim()+"' "
                    + "SELECT  'Return Value' = @return";
            int resultMa = Program.CheckDataHelper(query1);
            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                return false;
            }
            if (resultMa == 1)
            {
                MessageBox.Show("Số CMND đã tồn tại !", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }*/

        private bool CheckCMND()
        {
            // Kiểm tra trùng mã CMND
            string query1 = "SELECT dbo.FC_CHECK_CMND('"+txtCMND.Text.Trim()+"');";
            int resultMa = Program.CheckDataHelper(query1);
            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (resultMa == 1)
            {
                MessageBox.Show("Số CMND đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
            this.sP_DANHSACH_PHICONGBindingSource.AddNew();
            txtCMND.Enabled = true;
            hanhDong = "THEM";
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
            txtCMND.Enabled=false;
            hanhDong = "SUA";
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lAIBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa phi công này vì đã được chỉ định lái ",
                     "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            if (MessageBox.Show("Bạn có thực sự muốn xóa phi công này ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    //sP_DANHSACH_PHICONGBindingSource.RemoveCurrent();
                    ExecSP("EXEC SP_XOA_PHICONG '"+txtCMND.Text.Trim()+"'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa của hệ thống. Hãy xóa lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.sP_DANHSACH_PHICONGTableAdapter.Fill(this.dSSB.SP_DANHSACH_PHICONG);
                    return;
                }

                this.sP_DANHSACH_PHICONGTableAdapter.Fill(this.dSSB.SP_DANHSACH_PHICONG);
                MessageBox.Show("Xóa thành công phi công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtCMND.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" || txtHoTen.Text.Trim() == ""
                || txtMSBangLai.Text.Trim() == "" || txtNgayCap.Text.Trim() == "" || txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                String ngayCap = txtNgayCap.DateTime.Year.ToString() + '-' + txtNgayCap.DateTime.Month.ToString() + '-' + txtNgayCap.DateTime.Day.ToString();

                if (hanhDong == "THEM")
                    if (CheckCMND())
                    {
                        ExecSP("EXEC [SP_THEM_PHICONG] '" + txtCMND.Text + "', N'" + txtHoTen.Text + "', " +
                        "N'" + txtDiaChi.Text + "', '" + txtSDT.Text + "', '" + txtMSBangLai.Text + "', '" + ngayCap + "'");
                    }
                    else
                        return;
                if (hanhDong == "SUA")
                    ExecSP("EXEC [SP_SUA_PHICONG] '"+txtCMND.Text+"', N'"+txtHoTen.Text+"', " +
                        "N'"+txtDiaChi.Text+"', '"+txtSDT.Text+"', '"+txtMSBangLai.Text+"', '"+ ngayCap+ "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi phi công!!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            enableButton(false);
            this.sP_DANHSACH_PHICONGTableAdapter.Fill(this.dSSB.SP_DANHSACH_PHICONG);
            MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn hủy ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                enableButton(false);
                this.sP_DANHSACH_PHICONGBindingSource.CancelEdit();
                this.sP_DANHSACH_PHICONGTableAdapter.Fill(this.dSSB.SP_DANHSACH_PHICONG);
                sP_DANHSACH_PHICONGBindingSource.Position = 0;
            }
        }

        private void btnLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.sP_DANHSACH_PHICONGTableAdapter.Fill(this.dSSB.SP_DANHSACH_PHICONG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (btnGhi.Enabled) // nếu thông tin chưa được ghi
            {
                if (MessageBox.Show("Thông tin chưa được lưu. \n" +
                    "Bạn có thực sự muốn thoát ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
                return;
            }
        }
    }
}