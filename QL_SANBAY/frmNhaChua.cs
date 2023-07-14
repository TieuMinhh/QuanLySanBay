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
    public partial class frmNhaChua : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaChua()
        {
            InitializeComponent();
        }

        private void frmNhaChua_Load(object sender, EventArgs e)
        {
            dSSB.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSSB.NGUOI' table. You can move, or remove it, as needed.
            this.nGUOITableAdapter.Fill(this.dSSB.NGUOI);
            
            // TODO: This line of code loads data into the 'dSSB.MAYBAY' table. You can move, or remove it, as needed.
            this.mAYBAYTableAdapter.Fill(this.dSSB.MAYBAY);
            // TODO: This line of code loads data into the 'dSSB.NHACHUA' table. You can move, or remove it, as needed.
            this.nHACHUATableAdapter.Fill(this.dSSB.NHACHUA);
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

        private void nHACHUABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHACHUABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSB);

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
            this.nHACHUABindingSource.AddNew();
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (mAYBAYBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhà chứa này vì đã chứa máy bay ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa nhà chứa máy bay này ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    nHACHUABindingSource.RemoveCurrent();
                    this.nHACHUATableAdapter.Update(this.dSSB.NHACHUA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa của hệ thống. Hãy xóa lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.nHACHUATableAdapter.Fill(this.dSSB.NHACHUA);
                    return;
                }

                this.nHACHUATableAdapter.Fill(this.dSSB.NHACHUA);
                MessageBox.Show("Xóa thành công nhà chứa ! ", "Thông bá", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtSucChua.Text.Trim() == "" || txtViTri.Text.Trim() == "" || txtTenNha.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                this.nHACHUABindingSource.EndEdit();
                this.nHACHUABindingSource.ResetCurrentItem();
                this.nHACHUATableAdapter.Update(this.dSSB.NHACHUA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật nhà chứa máy bay!!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            enableButton(false);
            this.nHACHUATableAdapter.Fill(this.dSSB.NHACHUA);
            MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn hủy ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                enableButton(false);
                this.nHACHUABindingSource.CancelEdit();
                this.nHACHUATableAdapter.Fill(this.dSSB.NHACHUA);
            }
        }

        private void btnLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.nHACHUATableAdapter.Fill(this.dSSB.NHACHUA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload " + ex.Message, "Thông báo", MessageBoxButtons.OK);
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