using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QL_SANBAY
{
    public partial class rprtNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rprtNhanVien()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr_publiser;
            this.sqlDataSource1.Fill();
        }

    }
}
