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
    public partial class frmChuMayBay : DevExpress.XtraEditors.XtraForm
    {
        private String hanhDong = "";
        public frmChuMayBay()
        {
            InitializeComponent();
        }

        private void frmChuMayBay_Load(object sender, EventArgs e)
        {
            dSSB.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSSB.SOHUU' table. You can move, or remove it, as needed.
            this.sOHUUTableAdapter.Fill(this.dSSB.SOHUU);
            // TODO: This line of code loads data into the 'dSSB.SP_CHUMAYBAY_DOANHNGHIEP' table. You can move, or remove it, as needed.
            this.sP_CHUMAYBAY_DOANHNGHIEPTableAdapter.Fill(this.dSSB.SP_CHUMAYBAY_DOANHNGHIEP);
            // TODO: This line of code loads data into the 'dSSB.SP_CHUMAYBAY_NGUOI' table. You can move, or remove it, as needed.
            this.sP_CHUMAYBAY_NGUOITableAdapter.Fill(this.dSSB.SP_CHUMAYBAY_NGUOI);
            phanQuyen();
        }

        private void phanQuyen()
        {
            if (Program.Nhom.Trim() == "PHICONG")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnThemDN.Enabled = btnSuaDN.Enabled = btnXoaDN.Enabled = false;
            }
            else if (Program.Nhom.Trim() == "NHANVIEN")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnThemDN.Enabled = btnSuaDN.Enabled = btnXoaDN.Enabled = false;
            }
            else
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnThemDN.Enabled = btnSuaDN.Enabled = btnXoaDN.Enabled = true;
            }
        }

        private void enableButton(bool b)
        {
            btnGhi.Enabled = btnHuy.Enabled = panelControl5.Enabled = b;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = !b;
            panelControl1.Enabled = panelControl2.Enabled = !b;
            btnThemDN.Enabled = btnSuaDN.Enabled = btnXoaDN.Enabled = !b;
        }

        private void enableButton_DN(bool b)
        {
            btnGhi.Enabled = btnHuy.Enabled = panelControl6.Enabled = b;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = !b;
            panelControl1.Enabled = panelControl2.Enabled =  !b;
            btnThemDN.Enabled = btnSuaDN.Enabled = btnXoaDN.Enabled = !b;
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

        //SELECT dbo.FC_CHECK_MADN('DN011');

        private bool CheckMADN()
        {
            // Kiểm tra trùng mã DN
            string query1 = "SELECT dbo.FC_CHECK_MADN('"+txtMaDN.Text.Trim()+"');";
            int resultMa = Program.CheckDataHelper(query1);
            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (resultMa == 1)
            {
                MessageBox.Show("Mã DN đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
            this.sP_CHUMAYBAY_NGUOIBindingSource.AddNew();
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
            if (sOHUUBindingSource1.Count > 0)
            {
                MessageBox.Show("Không thể xóa người này vì đang sở hữu máy bay ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Ngài có thực sự muốn xóa người này ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    //sP_DANHSACH_PHICONGBindingSource.RemoveCurrent();
                    ExecSP("EXEC SP_XOA_CHU_NGUOI '" + txtCMND.Text.Trim() + "'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa của hệ thống. Hãy xóa lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.sP_CHUMAYBAY_NGUOITableAdapter.Fill(this.dSSB.SP_CHUMAYBAY_NGUOI);
                    return;
                }

                this.sP_CHUMAYBAY_NGUOITableAdapter.Fill(this.dSSB.SP_CHUMAYBAY_NGUOI);
                MessageBox.Show("Xóa thành công chủ máy bay ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemDN_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton_DN(true);
            this.sP_CHUMAYBAY_DOANHNGHIEPBindingSource.AddNew();
            txtMaDN.Enabled = true;
            hanhDong = "THEM";
        }

        private void btnSuaDN_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            enableButton_DN(true);
            hanhDong = "SUA";
        }

        private void btnXoaDN_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (sOHUUBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa doanh nghiệp này vì đang sở hữu máy bay ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Ngài có thực sự muốn xóa doanh nghiệp này ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    ExecSP("EXEC SP_XOA_CHU_DOANHNGHIEP '" + txtMaDN.Text.Trim() + "'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa của hệ thống. Hãy xóa lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.sP_CHUMAYBAY_DOANHNGHIEPTableAdapter.Fill(this.dSSB.SP_CHUMAYBAY_DOANHNGHIEP);
                    return;
                }

                this.sP_CHUMAYBAY_DOANHNGHIEPTableAdapter.Fill(this.dSSB.SP_CHUMAYBAY_DOANHNGHIEP);
                MessageBox.Show("Xóa thành công doanh nghiệp ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (panelControl5.Enabled)
            {
                if (txtCMND.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" || txtHoTen.Text.Trim() == ""
                    || txtSDT.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {

                    if (hanhDong == "THEM")
                        if (CheckCMND())
                        {
                            ExecSP("EXEC [SP_THEM_CHU_NGUOI] '"+txtCMND.Text.Trim()+"', N'"+txtHoTen.Text.Trim()+"', N'"+txtDiaChi.Text.Trim()+"', '"+txtSDT.Text.Trim()+"'");
                        }
                        else
                            return;
                    if (hanhDong == "SUA")
                        ExecSP("EXEC [SP_SUA_CHU_NGUOI] '" + txtCMND.Text.Trim() + "', N'" + txtHoTen.Text.Trim() + "', N'" + txtDiaChi.Text.Trim() + "', '" + txtSDT.Text.Trim() + "'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Người chủ!!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                enableButton(false);
                this.sP_CHUMAYBAY_NGUOITableAdapter.Fill(this.dSSB.SP_CHUMAYBAY_NGUOI);
                MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtMaDN.Text.Trim() == "" || txtTenDN.Text.Trim() == "" || txtSDTDN.Text.Trim() == ""
                    || txtDiaChiDN.Text.Trim() == "" || txtTenDaiDienDN.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {

                    if (hanhDong == "THEM")
                        if (CheckMADN())
                        {
                            ExecSP("EXEC [SP_THEM_CHU_DOANHNGHIEP] '"+txtMaDN.Text.Trim()+"', N'"+txtTenDN.Text.Trim()+"', N'"+txtSDTDN.Text.Trim()+"'," +
                                " N'"+txtDiaChiDN.Text.Trim()+"', N'"+txtTenDaiDienDN.Text.Trim()+"'");
                        }
                        else
                            return;
                    if (hanhDong == "SUA")
                        ExecSP("EXEC [SP_SUA_CHU_DOANHNGHIEP] '" + txtMaDN.Text.Trim() + "', N'" + txtTenDN.Text.Trim() + "', N'" + txtSDTDN.Text.Trim() + "'," +
                                " '" + txtDiaChiDN.Text.Trim() + "', N'" + txtTenDaiDienDN.Text.Trim() + "'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi doanh nghiệp!!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                enableButton_DN(false);
                this.sP_CHUMAYBAY_DOANHNGHIEPTableAdapter.Fill(this.dSSB.SP_CHUMAYBAY_DOANHNGHIEP);
                MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ngài có thực sự muốn hủy ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (panelControl5.Enabled)
                {
                    enableButton(false);
                    this.sP_CHUMAYBAY_NGUOIBindingSource.CancelEdit();
                    this.sP_CHUMAYBAY_NGUOITableAdapter.Fill(this.dSSB.SP_CHUMAYBAY_NGUOI);
                    sP_CHUMAYBAY_NGUOIBindingSource.Position = 0;
                }
                else
                {
                    enableButton_DN(false);
                    this.sP_CHUMAYBAY_DOANHNGHIEPBindingSource.CancelEdit();
                    this.sP_CHUMAYBAY_DOANHNGHIEPTableAdapter.Fill(this.dSSB.SP_CHUMAYBAY_DOANHNGHIEP);
                    sP_CHUMAYBAY_DOANHNGHIEPBindingSource.Position = 0;
                }
            }
        }

        private void btnLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.sP_CHUMAYBAY_NGUOITableAdapter.Fill(this.dSSB.SP_CHUMAYBAY_NGUOI);
                this.sP_CHUMAYBAY_DOANHNGHIEPTableAdapter.Fill(this.dSSB.SP_CHUMAYBAY_DOANHNGHIEP);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}