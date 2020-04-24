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
    public partial class Customer_Details : Form
    {
        public Customer_Details()
        {
            InitializeComponent();
        }
        Connection2 con2 = new Connection2();

        public void disp_data()
        {
            try
            {


                con2.dataGet2("select * from [dbo].[Billing_Details]");
                DataTable dt = new DataTable();
                con2.sda2.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["Customer_Name"].Value = row["Customer_Name"].ToString();
                    dataGridView1.Rows[n].Cells["Date"].Value = Convert.ToDateTime(row["Date"].ToString()).ToString("dd-MM-yyyy");
                    dataGridView1.Rows[n].Cells["Sub_Total"].Value = row["Sub_Total"].ToString();
                    dataGridView1.Rows[n].Cells["Discount"].Value = row["Discount"].ToString();
                    dataGridView1.Rows[n].Cells["Net_Total"].Value = row["Net_Total"].ToString();
                    dataGridView1.Rows[n].Cells["Paid"].Value = row["Paid"].ToString();
                    dataGridView1.Rows[n].Cells["Balance"].Value = row["Balance"].ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Customer_Details_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
            Bill_Output_Page bp = new Bill_Output_Page();
            bp.Show();
        }
    }
}
