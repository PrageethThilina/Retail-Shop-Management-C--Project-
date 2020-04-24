using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Group_Project
{
    public partial class Bill_Output_Page : Form
    {
        ReportDocument crypt = new ReportDocument();
        public Bill_Output_Page()
        {
            InitializeComponent();
        }

        private void Bill_Output_Page_Load(object sender, EventArgs e)
        {

        }

        private void Bill_Output_Page_Load_1(object sender, EventArgs e)
        {
            try
            {


                crypt.Load(@"C:\Users\Prageeth Thilina\source\repos\Group Project\Group Project\Bill_Report.rpt");
                Connection2 con2 = new Connection2();
                DataSet dst = new DataSet();
                con2.dataGet2("select top 1 Customer_Name,Date,Sub_Total,Discount,Net_Total,Paid,Balance from Billing_Details order by Date desc");
                con2.sda2.Fill(dst, "Billing_Details");
                crypt.SetDataSource(dst);
                crystalReportViewer1.ReportSource = crypt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
