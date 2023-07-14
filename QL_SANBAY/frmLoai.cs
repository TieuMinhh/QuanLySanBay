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
    public partial class frmLoai : DevExpress.XtraEditors.XtraForm
    {
        public frmLoai()
        {
            InitializeComponent();
        }

        private void frmLoai_Load(object sender, EventArgs e)
        {
            dSSB.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSSB.CHUYENVE' table. You can move, or remove it, as needed.
            this.cHUYENVETableAdapter.Fill(this.dSSB.CHUYENVE);
            // TODO: This line of code loads data into the 'dSSB.LAI' table. You can move, or remove it, as needed.
            this.lAITableAdapter.Fill(this.dSSB.LAI);
            // TODO: This line of code loads data into the 'dSSB.MAYBAY' table. You can move, or remove it, as needed.
            this.mAYBAYTableAdapter.Fill(this.dSSB.MAYBAY);
            // TODO: This line of code loads data into the 'dSSB.LOAI' table. You can move, or remove it, as needed.
            this.lOAITableAdapter.Fill(this.dSSB.LOAI);

            phanQuyen();
        }

        private void lOAIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOAIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSB);

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
            btnGhi.Enabled = btnHuy.Enabled = panelControl1.Enabled = b;

            btnThem.Enabled = btnSua.Enabled= btnXoa.Enabled=btnLamMoi.Enabled = !b;
            panelControl2.Enabled = !b;
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
            this.lOAIBindingSource.AddNew();
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (MessageBox.Show("Bạn có thực sự muốn hủy ?",
                    "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                enableButton(false);
                this.lOAIBindingSource.CancelEdit();
                this.lOAITableAdapter.Fill(this.dSSB.LOAI);
            }
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(txtSucChua.Text.Trim() == "" || txtKieuDang.Text.Trim() == "" || txtTrongLuong.Text.Trim() == "" || txtTenLoai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                this.lOAIBindingSource.EndEdit();
                this.lOAIBindingSource.ResetCurrentItem();
                this.lOAITableAdapter.Update(this.dSSB.LOAI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi loại máy bay!!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            enableButton(false);
            this.lOAITableAdapter.Fill(this.dSSB.LOAI);
            MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (mAYBAYBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa loại này vì đã chứa máy bay ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cHUYENVEBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa loại này vì đang có nhân viên chuyên về",
                    "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (lAIBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa loại này vì đang có phi công lái ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa loại máy bay này ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    lOAIBindingSource.RemoveCurrent();
                    this.lOAITableAdapter.Update(this.dSSB.LOAI);  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa của hệ thống. Hãy xóa lại\n" + ex.Message,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.lOAITableAdapter.Fill(this.dSSB.LOAI);
                    return;
                }

                this.lOAITableAdapter.Fill(this.dSSB.LOAI);
                MessageBox.Show("Ngài đã xóa thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
        }

        private void btnLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.lOAITableAdapter.Fill(this.dSSB.LOAI);
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