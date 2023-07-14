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
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private String chu = "SELECT * FROM V_HOTEN_CMND_CHU";
        private String nhanvien = "SELECT * FROM V_HOTEN_CMND_NHANVIEN";
        private String phicong = "SELECT * FROM V_HOTEN_CMND_PHICONG";

        private String role = "";
        public frmTaoTaiKhoan()
        {
            InitializeComponent();

        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
             cbxDoiTuong.SelectedIndex = 1; cbxDoiTuong.SelectedIndex = 0;
        }

        private bool InsertLogin()
        {
            // Kiểm tra trùng mã CMND
            string query1 = "DECLARE  @return int \n" +
            "EXEC @return = SP_TAOLOGIN @LGNAME = '"+txtTenTK.Text.Trim()+"', @PASS = '"+txtMatKhau.Text.Trim()+"', @USERNAME = '"+ cbxHoTen.SelectedValue.ToString()+"', @ROLE = '"+role+"' \n"
            +"SELECT  'Return Value' = @return";
            int resultMa = CheckDataHelper1(query1);
            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (resultMa == 1)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (resultMa == 2)
            {
                MessageBox.Show("Người này đã có tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public int CheckDataHelper1(String query) // dùng để check dữ liệu 1 kết quả số nguyên
        {
            Program.conn.ConnectionString = Program.connstr_publiser;
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

        public void LayHOTEN(String cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            cbxHoTen.DataSource = dt;
            cbxHoTen.DisplayMember = "HOTEN"; cbxHoTen.ValueMember = "CMND";
            cbxHoTen.SelectedIndex = 1; cbxHoTen.SelectedIndex = 0;
        }

        private void cbxDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxDoiTuong.SelectedIndex == 0)
            {
                LayHOTEN(chu);
                role = "CHUMAYBAY";
            }
            if (cbxDoiTuong.SelectedIndex == 1)
            {
                LayHOTEN(phicong);
                role = "PHICONG";
            }
            if (cbxDoiTuong.SelectedIndex == 2)
            {
                LayHOTEN(nhanvien);
                role = "NHANVIEN";
            }
        }

        private void cbxHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCMND.Text = cbxHoTen.SelectedValue.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thông tin chưa được lưu. \n" +
                    "Ngài có thực sự muốn thoát ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtTenTK.Text.Trim() == "" || txtMatKhau.Text.Trim() == "" || txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Ngài có thực sự muốn tạo tài khoản này ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                InsertLogin();
                MessageBox.Show("Tạo tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}