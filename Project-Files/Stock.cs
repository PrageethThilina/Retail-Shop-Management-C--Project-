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

namespace Group_Project
{
    public partial class Stock_Page : Form
    {
        public Stock_Page()

        {
            InitializeComponent();
        }
        Connection2 con2 = new Connection2();
        private void ClearData()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Item Id Required");
            }
           
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox2, "Item Name Required");
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox3, "Item Price Required");
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox4, "Item Quantity Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private bool IfIdExists(string Item_Name,string Item_Id)
        {

            con2.dataGet2("select 1 from [dbo].[Stock] where Item_Name='" +textBox2.Text + "'and Item_Id='" + textBox1.Text + "'");
            DataTable dt = new DataTable();
            con2.sda2.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (Validation())
                {
                    if (IfIdExists(textBox2.Text, textBox1.Text))
                    {
                        MessageBox.Show("Already selected Id or Name...!!!...Take a new Id...!!!", "Polkotuwa Stores");

                    }
                    else
                    {



                        DialogResult dr = MessageBox.Show("Are you sure want to Add", "Polkotuwa Stores", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {

                            con2.dataSend2("insert into [dbo].[Stock] (Item_Id,Item_Name,Item_Price,Item_Quantity) values('" + textBox1.Text.ToString() + "','" + textBox2.Text + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')");
                            MessageBox.Show("Record Added Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void disp_data()
        {
            con2.dataGet2("select * from [dbo].[Stock]");
            DataTable dt = new DataTable();
            con2.sda2.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Item_Id"].Value = row["Item_Id"].ToString();
                dataGridView1.Rows[n].Cells["Item_Name"].Value = row["Item_Name"].ToString();
                dataGridView1.Rows[n].Cells["Item_Price"].Value = row["Item_Price"].ToString();
                dataGridView1.Rows[n].Cells["Item_Quantity"].Value = row["Item_Quantity"].ToString();
               

            }
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            disp_data();
            ClearData();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dr = MessageBox.Show("Are you sure want to Remove", "Polkotuwa Stores", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    con2.dataSend2("delete from [dbo].[Stock] where Item_Id ='" + textBox1.Text + "'");


                    MessageBox.Show("Record Updated Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearData();
                disp_data();
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


                DialogResult dr = MessageBox.Show("Are you sure want to Update", "Polkotuwa Stores", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    con2.dataSend2("UPDATE [dbo].[Stock] SET Item_Id ='" + textBox1.Text + "', Item_Name ='" + textBox2.Text + "', Item_Price ='" + textBox3.Text + "', Item_Quantity ='" + textBox4.Text + "'");


                    MessageBox.Show("Record Updated Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                disp_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox2.Focus();
                }
                else
                {
                    textBox1.Focus();
                }               
                
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text.Length > 0)
                {
                    textBox3.Focus();
                }
                else
                {
                    textBox2.Focus();
                }

            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox3.Text.Length > 0)
                {
                    textBox4.Focus();
                }
                else
                {
                    textBox3.Focus();
                }

            }
        }

        private void userRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Register_Page bp = new User_Register_Page();
            bp.Show();
        }
    

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Page bp = new Login_Page();
            bp.Show();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billing_Page bp = new Billing_Page();
            bp.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Register_Page bp = new Employee_Register_Page();
            bp.Show();
        }
    

        private void budgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Budget_Page bp = new Budget_Page();
              bp.Show();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Page bp = new Main_Page();
            bp.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password_Page bp = new Change_Password_Page();
            bp.Show();
        }

        private void employeeRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Register_Page bp = new Employee_Register_Page();
            bp.Show();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {


                textBox1.Text = dataGridView1.SelectedRows[0].Cells["Item_Id"].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells["Item_Name"].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells["Item_Price"].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells["Item_Quantity"].Value.ToString();

                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }


}

       


