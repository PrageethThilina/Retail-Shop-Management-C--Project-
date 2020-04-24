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
    public partial class Budget_Page : Form
    {
        public Budget_Page()
        {
            InitializeComponent();
        }
        Connection3 con3 = new Connection3();


        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Page bp = new Login_Page();
            bp.Show();
        }

        private void userRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Register_Page bp = new User_Register_Page();
            bp.Show();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billing_Page bp = new Billing_Page();
            bp.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Page bp = new Stock_Page();
            bp.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Register_Page bp = new Employee_Register_Page();
            bp.Show();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Page bp = new Main_Page();
            bp.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearData()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;



        }
        void LoadData()
        {
            try
            {


                con3.dataGet3("Select * from [dbo].[Budget] ");
                DataTable dt = new DataTable();
                con3.sda3.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["Year"].Value = row["Year"].ToString();
                    dataGridView1.Rows[n].Cells["Month"].Value = row["Month"].ToString();
                    dataGridView1.Rows[n].Cells["CostForInventory"].Value = row["CostForInventory"].ToString();
                    dataGridView1.Rows[n].Cells["WaterBill"].Value = row["WaterBill"].ToString();
                    dataGridView1.Rows[n].Cells["LightBill"].Value = row["LightBill"].ToString();
                    dataGridView1.Rows[n].Cells["EmployeeTotalSalary"].Value = row["EmployeeTotalSalary"].ToString();
                    dataGridView1.Rows[n].Cells["Other"].Value = row["Other"].ToString();
                    dataGridView1.Rows[n].Cells["TotalIncome"].Value = row["TotalIncome"].ToString();
                    dataGridView1.Rows[n].Cells["NetIncomeForMonth"].Value = row["NetIncomeForMonth"].ToString();
                    dataGridView1.Rows[n].Cells["NetIncomeForYear"].Value = row["NetIncomeForYear"].ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


   

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                textBox7.Text = (Convert.ToInt32(textBox2.Text) - (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text))).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {


                con3.dataSend3(@"insert into [dbo].[Budget] (Year,Month,CostForInventory,WaterBill,LightBill,EmployeeTotalSalary,Other,TotalIncome,NetIncomeForMonth,NetIncomeForYear) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox2.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')");

                MessageBox.Show("Saved Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                con3.dataGet3("Select * from [dbo].[Budget] where Year ='" + comboBox1.Text + "' and Month='" + comboBox2.Text + "'");
                DataTable dt = new DataTable();
                con3.sda3.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["Year"].Value = row["Year"].ToString();
                    dataGridView1.Rows[n].Cells["Month"].Value = row["Month"].ToString();
                    dataGridView1.Rows[n].Cells["CostForInventory"].Value = row["CostForInventory"].ToString();
                    dataGridView1.Rows[n].Cells["WaterBill"].Value = row["WaterBill"].ToString();
                    dataGridView1.Rows[n].Cells["LightBill"].Value = row["LightBill"].ToString();
                    dataGridView1.Rows[n].Cells["EmployeeTotalSalary"].Value = row["EmployeeTotalSalary"].ToString();
                    dataGridView1.Rows[n].Cells["Other"].Value = row["Other"].ToString();
                    dataGridView1.Rows[n].Cells["TotalIncome"].Value = row["TotalIncome"].ToString();
                    dataGridView1.Rows[n].Cells["NetIncomeForMonth"].Value = row["NetIncomeForMonth"].ToString();
                    dataGridView1.Rows[n].Cells["NetIncomeForYear"].Value = row["NetIncomeForYear"].ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}



