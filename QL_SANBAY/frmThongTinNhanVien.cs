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
    public partial class frmThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            string strLenh = "EXEC SP_TAIKHOAN_NHANVIEN '" + Program.cmnd + "'";
            SqlDataReader myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();

            txtCMND.Text = myReader.GetString(0);
            txtHoten.Text = myReader.GetString(1);
            
            txtSDT.Text = myReader.GetString(2);
            txtDiaChi.Text = myReader.GetString(3);

            txtLuong.Text = myReader.GetDouble(4).ToString();
            txtCaLam.Text = myReader.GetString(5);

            myReader.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn lưu thay đổi ?",
                    "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ExecSP("EXEC [SP_SUA_NHANVIEN] '" + Program.cmnd + "', N'" + txtHoten.Text.Trim() + "', " +
                        "N'" + txtDiaChi.Text.Trim() + "', '" + txtSDT.Text.Trim() + "', '" + txtLuong.Text.Trim() + "', N'" + txtCaLam.Text.Trim() + "'");
            }

            MessageBox.Show("Cập nhật thông tin nhân viên thành công !", "", MessageBoxButtons.OK);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}