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
    public partial class frmPhiCongLaiMayBay : DevExpress.XtraEditors.XtraForm
    {
        public frmPhiCongLaiMayBay()
        {
            InitializeComponent();
        }

        private void frmPhiCongLaiMayBay_Load(object sender, EventArgs e)
        {
            lbCMND.Text = Program.cmnd;
            lbHoTen.Text = Program.HoTen;
            String sql = "EXEC SP_PHICONG_LAI_MAYBAY '" + Program.cmnd.ToString() + "'";
            DataTable dt = Program.ExecSqlDataTable(sql);

            PHICONGLAIGridView.DataSource = dt;
        }
    }
}