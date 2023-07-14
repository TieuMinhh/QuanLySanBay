using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SANBAY
{
    public partial class frmDichVuBaoTri : DevExpress.XtraEditors.XtraForm
    {
        public frmDichVuBaoTri()
        {
            InitializeComponent();
        }

        private void dICHVUBAOTRIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dICHVUBAOTRIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSB);

        }

        private void frmDichVuBaoTri_Load(object sender, EventArgs e)
        {
            dSSB.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSSB.BAOTRI' table. You can move, or remove it, as needed.
            this.bAOTRITableAdapter.Fill(this.dSSB.BAOTRI);
            // TODO: This line of code loads data into the 'dSSB.DICHVUBAOTRI' table. You can move, or remove it, as needed.
            this.dICHVUBAOTRITableAdapter.Fill(this.dSSB.DICHVUBAOTRI);

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

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
            this.dICHVUBAOTRIBindingSource.AddNew();
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bAOTRIBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa dịch vụ này vì đang bảo trì máy bay ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Ngài có thực sự muốn xóa dịch vụ này ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    dICHVUBAOTRIBindingSource.RemoveCurrent();
                    this.dICHVUBAOTRITableAdapter.Update(this.dSSB.DICHVUBAOTRI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa của hệ thống. Hãy xóa lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.dICHVUBAOTRITableAdapter.Fill(this.dSSB.DICHVUBAOTRI);
                    return;
                }

                this.dICHVUBAOTRITableAdapter.Fill(this.dSSB.DICHVUBAOTRI);
                MessageBox.Show("Xóa thành công dịch vụ bảo trì ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtTenDV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                this.dICHVUBAOTRIBindingSource.EndEdit();
                this.dICHVUBAOTRIBindingSource.ResetCurrentItem();
                this.dICHVUBAOTRITableAdapter.Update(this.dSSB.DICHVUBAOTRI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi dịch vụ!!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            enableButton(false);
            this.dICHVUBAOTRITableAdapter.Fill(this.dSSB.DICHVUBAOTRI);
            MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ngài có thực sự muốn hủy ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                enableButton(false);
                this.dICHVUBAOTRIBindingSource.CancelEdit();
                this.dICHVUBAOTRITableAdapter.Fill(this.dSSB.DICHVUBAOTRI);
            }
        }

        private void btnLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.dICHVUBAOTRITableAdapter.Fill(this.dSSB.DICHVUBAOTRI);
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