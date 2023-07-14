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
    public partial class frmTaiKhoanPhiCong : DevExpress.XtraEditors.XtraForm
    {
        public frmTaiKhoanPhiCong()
        {
            InitializeComponent();
        }

        private void frmTaiKhoanPhiCong_Load(object sender, EventArgs e)
        {
            string strLenh = "EXEC SP_TAIKHOAN_PHICONG '" + Program.cmnd + "'";
            SqlDataReader myReader = Program.ExecSqlDataReader(strLenh);
            if(myReader == null) return;
            myReader.Read();

            txtCMND.Text = myReader.GetString(0);
            txtHoten.Text = myReader.GetString(1);
            txtMaSoBangLai.Text = myReader.GetInt32(2).ToString();
            txtNgayCap.Text = myReader.GetDateTime(3).ToString();
            txtSDT.Text = myReader.GetString(4);
            txtDiaChi.Text = myReader.GetString(5);

            myReader.Close();
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn lưu thay đổi ?",
                    "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String ngayCap = txtNgayCap.DateTime.Year.ToString() + '-' + txtNgayCap.DateTime.Month.ToString() + '-' + txtNgayCap.DateTime.Day.ToString();

                ExecSP("EXEC [SP_SUA_PHICONG] '" + Program.cmnd + "', N'" + txtHoten.Text.Trim() + "', " +
                        "N'" + txtDiaChi.Text.Trim() + "', '" + txtSDT.Text.Trim() + "', '" + txtMaSoBangLai.Text.Trim() + "', '" + ngayCap + "'");

            }

            MessageBox.Show("Cập nhật thông tin phi công thành công !", "", MessageBoxButtons.OK);
        }
    }
}