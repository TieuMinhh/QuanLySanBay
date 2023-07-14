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

namespace QL_SANBAY
{
    public partial class frmChiTietNhanVienBaoTri : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietNhanVienBaoTri()
        {
            InitializeComponent();
        }

        private void frmChiTietNhanVienBaoTri_Load(object sender, EventArgs e)
        {
            lbCMND.Text = Program.cmnd;
            lbHoten.Text = Program.HoTen;
            String sql = "EXEC SP_NHANVIEN_BAOTRI '" + Program.cmnd.ToString() + "'";
            DataTable dt = Program.ExecSqlDataTable(sql);

            CTNhanVienBaoTriGridControl.DataSource = dt;
        }
    }
}