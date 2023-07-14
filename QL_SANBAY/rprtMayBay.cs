using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QL_SANBAY
{
    public partial class rprtMayBay : DevExpress.XtraReports.UI.XtraReport
    {
        public rprtMayBay()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr_publiser;
            this.sqlDataSource1.Fill();
        }

    }
}
