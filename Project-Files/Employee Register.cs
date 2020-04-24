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
using System.IO;

namespace Group_Project
{
    public partial class Employee_Register_Page : Form
    {
        string fileName;
        public Employee_Register_Page()
        {

            InitializeComponent();

        }
        Connection3 con3 = new Connection3();
        private bool Validation()
        {
            


                bool result = false;
                if (string.IsNullOrEmpty(textBox5.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textBox5, "Name Required");
                }

                else if (string.IsNullOrEmpty(textBox2.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textBox2, "Mobile No Required");
                }

                else if (string.IsNullOrEmpty(textBox6.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textBox6, "Email Required");
                }
                else if (string.IsNullOrEmpty(textBox7.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textBox7, "Address Required");
                }

                else
                {
                    errorProvider1.Clear();
                    result = true;
                }
                return result;
          
        }
        private void ClearData()
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.Image = null;
        }

        private void disp_data()
        {
            try
            {


                con3.dataGet3("select * from [dbo].[Employee_Register]");
                DataTable dt = new DataTable();
                con3.sda3.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["EmpId"].Value = row["EmpId"].ToString();
                    dataGridView1.Rows[n].Cells["EmpName"].Value = row["Name"].ToString();
                    dataGridView1.Rows[n].Cells["Mobile"].Value = row["Mobile"].ToString();
                    dataGridView1.Rows[n].Cells["Email"].Value = row["Email"].ToString();
                    dataGridView1.Rows[n].Cells["Dob"].Value = Convert.ToDateTime(row["Dob"].ToString()).ToString("dd-MM-yyyy");
                    dataGridView1.Rows[n].Cells["BankDetails"].Value = row["BankDetails"].ToString();
                    dataGridView1.Rows[n].Cells["Address"].Value = row["Address"].ToString();
                    


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        private bool IfEmployeeExists(string Name, string Mobile)
        {
           
                con3.dataGet3("select 1 from [dbo].[Employee_Register] where Name='" + Name + "'and Mobile='" + Mobile + "'");
                DataTable dt = new DataTable();
                con3.sda3.Fill(dt);
                if (dt.Rows.Count > 0)
                    return true;
                else
                    return false;
           


        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        fileName = ofd.FileName;
                        label9.Text = fileName;
                        pictureBox1.Image = Image.FromFile(fileName);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Employee_Register_Page_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox5;
           // disp_data();
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox5.Text.Length > 0)
                {
                    textBox2.Focus();
                }
                else
                {
                    textBox5.Focus();
                }

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text.Length > 0)
                {
                    textBox6.Focus();
                }
                else
                {
                    textBox2.Focus();
                }

            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox6.Text.Length > 0)
                {
                    dateTimePicker1.Focus();
                }
                else
                {
                    textBox6.Focus();
                }

            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dateTimePicker1.Text.Length > 0)
                {
                    textBox4.Focus();
                }
                else
                {
                    dateTimePicker1.Focus();
                }

            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox4.Text.Length > 0)
                {
                    textBox7.Focus();
                }
                else
                {
                    textBox4.Focus();
                }
            }
        }
      
   
   
       
    
   

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                if (Validation())
                {
                    
                    if (IfEmployeeExists(textBox5.Text, textBox2.Text))
                    {
                        MessageBox.Show("Employee already Exists");
                    }
                    else
                    {

                        DialogResult dr = MessageBox.Show("Are you sure want to Save Record", "Polkotuwa Stores", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            Connection3 con3 = new Connection3();
                            con3.dataSend3("insert into [dbo].[Employee_Register] (Name,Mobile,Email,Dob,BankDetails,Address) values('" + textBox5.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + textBox6.Text.ToString() + "', '" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "', '" + textBox4.Text.ToString() + "', '" + textBox7.Text.ToString() + "', '" + "')");
                            MessageBox.Show("Record Saved Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            disp_data();

                        }
                        ClearData();
                    }

                }
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

                DialogResult dr = MessageBox.Show("Are you sure want to Update", "Polkotuwa Stores", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    con3.dataSend3("UPDATE [dbo].[Employee_Register] SET Email ='" + textBox6.Text + "', BankDetails ='" + textBox4.Text + "', Address ='" + textBox7.Text  + "'where EmpId='" + textBox1.Text + "'");


                    MessageBox.Show("Record Updated Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }
                disp_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells["EmpId"].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells["EmpName"].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells["Mobile"].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells["Dob"].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells["BankDetails"].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells["Address"].Value.ToString();
                
                button3.Enabled = false;
                button4.Enabled = true;
                button5.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {



                DialogResult dr = MessageBox.Show("Are you sure want to Delete", "Polkotuwa Stores", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    con3.dataSend3("Delete From [dbo].[Employee_Register] where EmpId='" + textBox1.Text + "'");


                    MessageBox.Show("Record Deleted Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }
                disp_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
