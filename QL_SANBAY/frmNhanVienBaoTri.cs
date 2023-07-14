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
    public partial class frmNhanVienBaoTri : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVienBaoTri()
        {
            InitializeComponent();
        }

        private void bAOTRIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bAOTRIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSB);

        }

        private void frmNhanVienBaoTri_Load(object sender, EventArgs e)
        {
            dSSB.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSSB.CTNHANVIENBAOTRI' table. You can move, or remove it, as needed.
            this.cTNHANVIENBAOTRITableAdapter.Fill(this.dSSB.CTNHANVIENBAOTRI);
            // TODO: This line of code loads data into the 'dSSB.BAOTRI' table. You can move, or remove it, as needed.
            this.bAOTRITableAdapter.Fill(this.dSSB.BAOTRI);

            LayNHANVIEN("SELECT * FROM V_HOTEN_CMND_NHANVIEN");

            phanQuyen();
        }

        private void phanQuyen()
        {
            if (Program.Nhom.Trim() == "PHICONG")
            {
                bntThem.Enabled = btnHuy.Enabled = btnHuy.Enabled = false;
            }
            else if (Program.Nhom.Trim() == "NHANVIEN")
            {
                bntThem.Enabled = btnHuy.Enabled = btnHuy.Enabled = false;
            }
            else
            {
                bntThem.Enabled = btnHuy.Enabled = btnHuy.Enabled = true;
            }
        }

        public void LayNHANVIEN(String cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            cbxNhanVien.DataSource = dt;
            cbxNhanVien.DisplayMember = "HOTEN"; cbxNhanVien.ValueMember = "CMND";
            cbxNhanVien.SelectedIndex = 1; cbxNhanVien.SelectedIndex = 0;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            btnGhi.Enabled = true;
            cbxNhanVien.Enabled = true;
            btnHuy.Enabled = false;
            bntThem.Enabled = false;

            cTNHANVIENBAOTRIBindingSource.AddNew();
            txtMaDK.Text = ((DataRowView)bAOTRIBindingSource[bAOTRIBindingSource.Position])["MADANGKY"].ToString();
            txtMaDV.Text = ((DataRowView)bAOTRIBindingSource[bAOTRIBindingSource.Position])["MADICHVU"].ToString();
            txtNgay.Text = ((DataRowView)bAOTRIBindingSource[bAOTRIBindingSource.Position])["NGAY"].ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (txtMaDK.Text.Trim() == "" || txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Ngài có thực sự muốn xóa nhân viên khỏi đợt bảo trì này ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    cTNHANVIENBAOTRIBindingSource.RemoveCurrent();
                    this.cTNHANVIENBAOTRITableAdapter.Update(this.dSSB.CTNHANVIENBAOTRI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên khỏi bảo trì.Hãy xóa lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cTNHANVIENBAOTRITableAdapter.Fill(this.dSSB.CTNHANVIENBAOTRI);
                    return;
                }

                this.cTNHANVIENBAOTRITableAdapter.Fill(this.dSSB.CTNHANVIENBAOTRI);
                cTNHANVIENBAOTRIBindingSource.Position = 0;
                MessageBox.Show("Xóa thành công nhân viên khỏi đợt bảo trì ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbxNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnGhi.Enabled == true)
                txtCMND.Text = cbxNhanVien.SelectedValue.ToString();
        }

        private void txtCMND_EditValueChanged(object sender, EventArgs e)
        {
            if (btnGhi.Enabled == false)
            {
                String maLoai = "";
                if (cTNHANVIENBAOTRIBindingSource.Position >= 0)
                {
                    maLoai = ((DataRowView)cTNHANVIENBAOTRIBindingSource[cTNHANVIENBAOTRIBindingSource.Position])["CMND"].ToString();
                }
                if (maLoai != "")
                    cbxNhanVien.SelectedValue = maLoai;
                else
                    cbxNhanVien.SelectedValue = 1;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtMaDK.Text.Trim() == "" || txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn thêm nhân viên vào đợt bảo trì này ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    this.cTNHANVIENBAOTRIBindingSource.EndEdit();
                    this.cTNHANVIENBAOTRIBindingSource.ResetCurrentItem();
                    this.cTNHANVIENBAOTRITableAdapter.Update(this.dSSB.CTNHANVIENBAOTRI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm nhân viên vào đợt bảo trì!!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.cTNHANVIENBAOTRITableAdapter.Fill(this.dSSB.CTNHANVIENBAOTRI);
                MessageBox.Show("Thêm thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnGhi.Enabled = cbxNhanVien.Enabled = false;
                btnHuy.Enabled = bntThem.Enabled = true;
            }
        }
    }
}