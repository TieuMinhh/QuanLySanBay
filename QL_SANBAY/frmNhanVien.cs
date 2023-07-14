using DevExpress.XtraBars;
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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private String hanhDong = "";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dSSB.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSSB.CTNHANVIENBAOTRI' table. You can move, or remove it, as needed.
            this.cTNHANVIENBAOTRITableAdapter.Fill(this.dSSB.CTNHANVIENBAOTRI);
            // TODO: This line of code loads data into the 'dSSB.CHUYENVE' table. You can move, or remove it, as needed.
            this.cHUYENVETableAdapter.Fill(this.dSSB.CHUYENVE);
            dSSB.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSSB.SP_DANHSACH_NHANVIEN' table. You can move, or remove it, as needed.
            this.sP_DANHSACH_NHANVIENTableAdapter.Fill(this.dSSB.SP_DANHSACH_NHANVIEN);

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
                MessageBox.Show("Lỗi exec SP \n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private bool CheckCMND()
        {
            // Kiểm tra trùng mã CMND
            string query1 = "SELECT dbo.FC_CHECK_CMND('" + txtCMND.Text.Trim() + "');";
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
            this.sP_DANHSACH_NHANVIENBindingSource.AddNew();
            txtCMND.Enabled = true;
            hanhDong = "THEM";
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
            txtCMND.Enabled = false;
            hanhDong = "SUA";
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cTNHANVIENBAOTRIBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đang bảo trì máy bay ",
                     "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cHUYENVEBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa phi công này vì đang chuyên về loại máy bay ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Ngài có thực sự muốn xóa nhân viên này ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    //sP_DANHSACH_PHICONGBindingSource.RemoveCurrent();
                    ExecSP("EXEC SP_XOA_NHANVIEN '" + txtCMND.Text.Trim() + "'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa của hệ thống. Hãy xóa lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.sP_DANHSACH_NHANVIENTableAdapter.Fill(this.dSSB.SP_DANHSACH_NHANVIEN);
                    return;
                }

                this.sP_DANHSACH_NHANVIENTableAdapter.Fill(this.dSSB.SP_DANHSACH_NHANVIEN);
                MessageBox.Show("Xóa thành công nhân viên ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtCMND.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" || txtHoTen.Text.Trim() == ""
                || txtCaLam.Text.Trim() == "" || txtLuong.Text.Trim() == "" || txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                if (hanhDong == "THEM")
                    if (CheckCMND())
                    {
                        ExecSP("EXEC [SP_THEM_NHANVIEN] '" + txtCMND.Text + "', N'" + txtHoTen.Text + "', " +
                        "N'" + txtDiaChi.Text + "', '" + txtSDT.Text + "', '" + txtLuong.Text + "', N'" + txtCaLam.Text + "'");
                    }
                    else
                        return;
                if (hanhDong == "SUA")
                    ExecSP("EXEC [SP_SUA_NHANVIEN] '" + txtCMND.Text + "', N'" + txtHoTen.Text + "', " +
                        "N'" + txtDiaChi.Text + "', '" + txtSDT.Text + "', '" + txtLuong.Text + "', N'" + txtCaLam.Text + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên!!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            enableButton(false);
            this.sP_DANHSACH_NHANVIENTableAdapter.Fill(this.dSSB.SP_DANHSACH_NHANVIEN);
            MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ngài có thực sự muốn hủy ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                enableButton(false);
                this.sP_DANHSACH_NHANVIENBindingSource.CancelEdit();
                this.sP_DANHSACH_NHANVIENTableAdapter.Fill(this.dSSB.SP_DANHSACH_NHANVIEN);
                sP_DANHSACH_NHANVIENBindingSource.Position = 0;
            }
        }

        private void btnLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.sP_DANHSACH_NHANVIENTableAdapter.Fill(this.dSSB.SP_DANHSACH_NHANVIEN);
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
                    "Ngài có thực sự muốn thoát ?",
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