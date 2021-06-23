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
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;

namespace Randholi_POS
{
    public partial class frm_invoice : Form
    {
        int orderNumber;
        public frm_invoice(int oNumber)
        {
            InitializeComponent();
            orderNumber = oNumber;
        }

        private void frm_invoice_Load(object sender, EventArgs e)
        {

            string path = ConfigurationManager.AppSettings.Get("ReportPath");
            ReportDocument cryRpt = new ReportDocument();

            //cryRpt.Load(@path + "Bill.rpt");

            cryRpt.Load(@path + "kotBot.rpt");
            cryRpt.SetParameterValue("@oCode", orderNumber);
            cryRpt.SetParameterValue("@iCat", "K");
            cryRpt.SetParameterValue("@stat", "N");

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            //cryRpt.PrintToPrinter(1, false, 0, 0);

            cryRpt.Load(@path + "kotBot.rpt");
            cryRpt.SetParameterValue("@oCode", orderNumber);
            cryRpt.SetParameterValue("@iCat", "B");
            cryRpt.SetParameterValue("@stat", "N");

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            //cryRpt.PrintToPrinter(1, false, 0, 0);

            this.Close();
        }
    }
}
