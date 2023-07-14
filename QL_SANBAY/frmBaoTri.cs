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
    public partial class frmBaoTri : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoTri()
        {
            InitializeComponent();
        }

        private void frmBaoTri_Load(object sender, EventArgs e)
        {
            dSSB.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSSB.CTNHANVIENBAOTRI' table. You can move, or remove it, as needed.
            this.cTNHANVIENBAOTRITableAdapter.Fill(this.dSSB.CTNHANVIENBAOTRI);
            
            // TODO: This line of code loads data into the 'dSSB.BAOTRI' table. You can move, or remove it, as needed.
            this.bAOTRITableAdapter.Fill(this.dSSB.BAOTRI);

            LayMAYBAY("SELECT * FROM V_TENMAYBAY_MADK");
            LayDICHVU("SELECT * FROM V_TEN_MA_DICHVU");

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

        private void bAOTRIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bAOTRIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSB);

        }

        private void enableButton(bool b)
        {
            btnGhi.Enabled = btnHuy.Enabled = panelControl2.Enabled = b;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = !b;
            panelControl1.Enabled = !b;
        }

        public void LayMAYBAY(String cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            cbxMayBay.DataSource = dt;
            cbxMayBay.DisplayMember = "TEN"; cbxMayBay.ValueMember = "MADANGKY";
            cbxMayBay.SelectedIndex = 1; cbxMayBay.SelectedIndex = 0;
        }

        public void LayDICHVU(String cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            cbxDichVu.DataSource = dt;
            cbxDichVu.DisplayMember = "TENDICHVU"; cbxDichVu.ValueMember = "MA";
            cbxDichVu.SelectedIndex = 1; cbxDichVu.SelectedIndex = 0;
        }

        private void cbxMayBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnGhi.Enabled == true)
                txtMaDK.Text = cbxMayBay.SelectedValue.ToString();
        }

        private void cbxDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnGhi.Enabled == true)
                txtMaDV.Text = cbxDichVu.SelectedValue.ToString();
        }

        private void txtMaDK_EditValueChanged(object sender, EventArgs e)
        {
            if (btnGhi.Enabled == false)
            {
                String maDK = "";
                if (bAOTRIBindingSource.Position >= 0)
                {
                    maDK = ((DataRowView)bAOTRIBindingSource[bAOTRIBindingSource.Position])["MADANGKY"].ToString();
                }
                if (maDK != "")
                    cbxMayBay.SelectedValue = maDK;
                else
                    cbxMayBay.SelectedValue = 1;
            }
        }

        private void txtMaDV_EditValueChanged(object sender, EventArgs e)
        {
            if (btnGhi.Enabled == false)
            {
                String maDV = "";
                if (bAOTRIBindingSource.Position != -1)
                {
                    maDV = ((DataRowView)bAOTRIBindingSource[bAOTRIBindingSource.Position])["MADICHVU"].ToString();
                }
                if (maDV != "")
                    cbxDichVu.SelectedValue = maDV;
                else
                    cbxDichVu.SelectedValue = 1;
            }
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
            this.bAOTRIBindingSource.AddNew();
            cbxDichVu.Enabled = true;
            cbxMayBay.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
            cbxDichVu.Enabled = false;
            cbxMayBay.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(cTNHANVIENBAOTRIBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa vì đang có nhân viên bảo trì! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Ngài có thực sự muốn xóa đợt bảo trì này ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    bAOTRIBindingSource.RemoveCurrent();
                    this.bAOTRITableAdapter.Update(this.dSSB.BAOTRI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đợt bảo trì này đã có nhân viên làm việc. \n Không thể xóa\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.bAOTRITableAdapter.Fill(this.dSSB.BAOTRI);
                    return;
                }

                this.bAOTRITableAdapter.Fill(this.dSSB.BAOTRI);
                bAOTRIBindingSource.Position = 0;
                MessageBox.Show("Xóa thành công đợt bảo trì ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMaDV.Text.Trim() == "" || txtMaDK.Text.Trim() == "" || txtNgay.Text.Trim() == "" 
                || txtSoGio.Text.Trim() == "" || txtNoiDung.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                this.bAOTRIBindingSource.EndEdit();
                this.bAOTRIBindingSource.ResetCurrentItem();
                this.bAOTRITableAdapter.Update(this.dSSB.BAOTRI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi bảo trì!!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            enableButton(false);
            this.bAOTRITableAdapter.Fill(this.dSSB.BAOTRI);
            MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ngài có thực sự muốn hủy ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                enableButton(false);
                this.bAOTRIBindingSource.CancelEdit();
                this.bAOTRITableAdapter.Fill(this.dSSB.BAOTRI);
                bAOTRIBindingSource.Position = 0;
            }
        }

        private void btnLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.bAOTRITableAdapter.Fill(this.dSSB.BAOTRI);
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