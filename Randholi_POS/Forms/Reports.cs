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
    public partial class frm_reports : Form
    {
        int orderNumber;
        public frm_reports()
        {
            InitializeComponent();

            //orderNumber = oNumber;
            timer1.Start();
            HideNavBar();
            nav1.Show();
        }

        private void HideNavBar()
        {
            nav1.Hide();
            nav2.Hide();
            nav3.Hide();
            nav4.Hide();
            nav5.Hide();
            nav6.Hide();
        }
        private void btn_sale_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav1.Show();
        }

        private void btn_menuItem_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav2.Show();
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav3.Show();
        }

        private void btn_voidReport_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav4.Show();
        }

        private void btn_kotBot_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav5.Show();

            string path = ConfigurationManager.AppSettings.Get("ReportPath");
            ReportDocument cryRpt = new ReportDocument();

            cryRpt.Load(@path + "kotBot.rpt");

            cryRpt.SetParameterValue("@iCat", "K");
            cryRpt.SetParameterValue("@oCode", 1003);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void btn_userAct_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav6.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtm = DateTime.Now;
            this.lbl_date.Text = dtm.ToString();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_reports_Load(object sender, EventArgs e)
        {
            
        }
    }
}
