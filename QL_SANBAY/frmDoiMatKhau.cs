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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
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

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtMatKhauCu.Text.Trim() == "" || txtMatKhauCu.Text.Trim() == "" || txtMatKhauCu.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin \n", "", MessageBoxButtons.OK);
                return;
            }
            if(Program.password != txtMatKhauCu.Text.Trim())
            {
                MessageBox.Show("Mật khẩu cũ chưa chính xác", "", MessageBoxButtons.OK);
                return;
            }
            if (txtMatKhauMoi.Text.Trim() != txtMatKhauXacNhan.Text.Trim())
            {
                MessageBox.Show("Mật khẩu xác nhận chưa trùng khớp", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn thay đổi mật khẩu ?",
                    "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String sql = "EXEC sp_password '"+txtMatKhauCu.Text.Trim()+"', '" + txtMatKhauMoi.Text.Trim() + "', '" + Program.mlogin + "'";
                ExecSP(sql);
                Program.password = txtMatKhauMoi.Text.Trim();
                MessageBox.Show("Đổi mật khẩu thành công", "", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thông tin chưa được lưu. \n" +
                    "Bạn có thực sự muốn thoát ?",
                    "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}