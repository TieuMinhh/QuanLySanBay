using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QL_SANBAY
{
    internal static class Program
    {

        public static SqlConnection conn = new SqlConnection();
        public static SqlDataReader myReader;
        public static String connstr;
        public static String connstr_publiser = @"Data Source=XIAOMING;Initial Catalog=QLSB;Persist Security Info=True;User ID=sa;Password=123";
        public static String connstr_publiser1 = @"Data Source=XIAOMING;Initial Catalog=QLSB;Persist Security Info=True;User ID=sa;Password=123";
        public static String database = "QLSB";
        public static string mlogin;
        public static String password;

        public static String cmnd = "";
        public static String HoTen = "";
        public static String Nhom = "";

        public static BindingSource bds_dspm = new BindingSource();
        public static frmMain frmChinh;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                connstr = @"Data Source=XIAOMING;Initial Catalog=QLSB;Persist Security Info=True;User ID=" + mlogin + ";Password=" + password + "";
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu gốc bằng tài khoản đăng nhập.\n" + ex.Message);
                return 0;
            }
        }


        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        //--------------------Thêm------
        public static void ExecSQLCommand(SqlCommand sqlCommand, SqlConnection conn)
        {
            if (Program.conn.State == System.Data.ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                sqlCommand.ExecuteNonQuery();
                //Program.conn.Open();
            }
            catch (SqlException e)
            {
                if (e.Message.Contains("Loi ket noi data ExecSQLCommand")) MessageBox.Show("loi");
                else MessageBox.Show(e.Message);
                Program.conn.Close();
            }

        }

        //--------------------them------

        public static int CheckDataHelper(String query) // dùng để check dữ liệu 1 kết quả số nguyên
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                return -1;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }
    }
}
