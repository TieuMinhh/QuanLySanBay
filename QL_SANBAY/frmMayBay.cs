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
    public partial class frmMayBay : DevExpress.XtraEditors.XtraForm
    {
        public frmMayBay()
        {
            InitializeComponent();
        }

        private void mAYBAYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mAYBAYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSB);

            
        }

        

        private void frmMayBay_Load(object sender, EventArgs e)
        {
            dSSB.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSSB.BAOTRI' table. You can move, or remove it, as needed.
            this.bAOTRITableAdapter.Fill(this.dSSB.BAOTRI);
            // TODO: This line of code loads data into the 'dSSB.SOHUU' table. You can move, or remove it, as needed.
            this.sOHUUTableAdapter.Fill(this.dSSB.SOHUU);
            // TODO: This line of code loads data into the 'dSSB.MAYBAY' table. You can move, or remove it, as needed.
            this.mAYBAYTableAdapter.Fill(this.dSSB.MAYBAY);

            LayLOAI("SELECT * FROM V_MALOAI_TENLOAI");
            LayNHACHUA("SELECT * FROM V_MANHA_TENNHA");

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

        public void LayLOAI(String cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            cbxLoai.DataSource = dt;
            cbxLoai.DisplayMember = "TENLOAI"; cbxLoai.ValueMember = "MALOAI";
            cbxLoai.SelectedIndex = 1; cbxLoai.SelectedIndex = 0;
        }

        public void LayNHACHUA(String cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            cbxNhaChua.DataSource = dt;
            cbxNhaChua.DisplayMember = "TENNHA"; cbxNhaChua.ValueMember = "MANHA";
            cbxNhaChua.SelectedIndex = 1; cbxNhaChua.SelectedIndex = 0;
        }

        private void cbxLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnGhi.Enabled == true)
                txtMaLoai.Text = cbxLoai.SelectedValue.ToString();
        }

        private void cbxNhaChua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnGhi.Enabled == true)
                txtMaNha.Text = cbxNhaChua.SelectedValue.ToString();
        }

        private void txtMaLoai_EditValueChanged(object sender, EventArgs e)
        {
            if (btnGhi.Enabled == false)
            {
                String maLoai = "";
                if (mAYBAYBindingSource.Position >= 0)
                {
                    maLoai = ((DataRowView)mAYBAYBindingSource[mAYBAYBindingSource.Position])["MALOAI"].ToString();
                }
                if(maLoai != "")
                    cbxLoai.SelectedValue = maLoai;
                else
                    cbxLoai.SelectedValue = 1;
            }
        }

        private void txtMaNha_EditValueChanged(object sender, EventArgs e)
        {
            if (btnGhi.Enabled == false)
            {
                String maNha = "";
                if (mAYBAYBindingSource.Position != -1)
                {
                    maNha = ((DataRowView)mAYBAYBindingSource[mAYBAYBindingSource.Position])["MANHA"].ToString();
                }
                if (maNha != "")
                    cbxNhaChua.SelectedValue = maNha;
                else
                    cbxNhaChua.SelectedValue = 1;
            }
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
            this.mAYBAYBindingSource.AddNew();
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableButton(true);
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (sOHUUBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa máy bày này vì đã được sở hữu ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bAOTRIBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa máy bay này vì đang được bảo trì ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa máy bay này ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    mAYBAYBindingSource.RemoveCurrent();
                    this.mAYBAYTableAdapter.Update(this.dSSB.MAYBAY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa của hệ thống. Hãy xóa lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.mAYBAYTableAdapter.Fill(this.dSSB.MAYBAY);
                    return;
                }

                this.mAYBAYTableAdapter.Fill(this.dSSB.MAYBAY);
                mAYBAYBindingSource.Position = 0;
                MessageBox.Show("Xóa thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtTen.Text.Trim() == "" || txtMaLoai.Text.Trim() == "" || txtMaNha.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                this.mAYBAYBindingSource.EndEdit();
                this.mAYBAYBindingSource.ResetCurrentItem();
                this.mAYBAYTableAdapter.Update(this.dSSB.MAYBAY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi máy bay!!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            enableButton(false);
            this.mAYBAYTableAdapter.Fill(this.dSSB.MAYBAY);
            MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn hủy ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                enableButton(false);
                this.mAYBAYBindingSource.CancelEdit();
                this.mAYBAYTableAdapter.Fill(this.dSSB.MAYBAY);
                mAYBAYBindingSource.Position = 0;
            }
        }

        private void btnLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.mAYBAYTableAdapter.Fill(this.dSSB.MAYBAY);
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