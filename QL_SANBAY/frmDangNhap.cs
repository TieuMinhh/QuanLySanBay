using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_SANBAY
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private String goiSP = "EXEC SP_Lay_Thong_Tin_DN_Tu_Login '";
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGoc() == 0) return;
        }

        private int KetNoi_CSDLGoc()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publiser;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu gốc.\n" + ex.Message);
                return 0;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            Program.mlogin = txtTenDN.Text; Program.password = txtMK.Text;

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Thông tin đăng nhập chưa chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 

            string strLenh = "EXEC SP_Lay_Thong_Tin_DN_Tu_Login '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.cmnd = Program.myReader.GetString(0);
            Program.HoTen = Program.myReader.GetString(1);
            Program.Nhom = Program.myReader.GetString(2);

            Program.myReader.Close();
            Program.conn.Close();

            MessageBox.Show("Đã đăng nhập thành công với đối tượng " + Program.Nhom, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            Program.frmChinh.HienThi();
        }

        private void cbxDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
             txtMK.UseSystemPasswordChar = !txtMK.UseSystemPasswordChar;
        }
    }
}