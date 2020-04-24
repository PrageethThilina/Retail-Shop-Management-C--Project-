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
using System.Globalization;

namespace Group_Project
{
    public partial class User_Register_Page : Form
    {
        public User_Register_Page()
        {
            InitializeComponent();
        }

        Connection1 con1 = new Connection1();

        private void ClearData()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1;
            
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            dateTimePicker1.Value = DateTime.Now;
           
        }
        private bool IfUserNameExists(string USERNAME)
        {
            con1.dataGet1("select * from [dbo].[Login] where USERNAME='" + textBox2.Text + "'");

            DataTable dt = new DataTable();
            con1.sda1.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void disp_data()
        {
            con1.dataGet1("select * from [dbo].[Login]");
            DataTable dt = new DataTable();
            con1.sda1.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach(DataRow row in dt.Rows)
            {

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["User_Id"].Value = n+1;

                dataGridView1.Rows[n].Cells["Full_Name"].Value = row["Name"].ToString();
                dataGridView1.Rows[n].Cells["USERNAME"].Value = row["PASSWORD"].ToString();
                dataGridView1.Rows[n].Cells["Address"].Value = row["Address"].ToString();
                dataGridView1.Rows[n].Cells["Email"].Value = row["Email"].ToString();
                dataGridView1.Rows[n].Cells["Dob"].Value = Convert.ToDateTime(row["Dob"].ToString()).ToString("dd-MM-yyyy");
                dataGridView1.Rows[n].Cells["Role"].Value = row["Role"].ToString();
            }
            
        }
        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Name Required");
            }

            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox2, "User Name Required");
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox3, "Password Required");
            }
            else if (textBox3.Text.Length < 4)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox3, "Password Minimum 4 Characters Required");
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox4, "Email Required");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(comboBox1, "Select Role");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
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

        private void Salary_Load(object sender, EventArgs e)
        {
            try
            {


                this.ActiveControl = textBox1;
                disp_data();
                button2.Enabled = false;
                button3.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    textBox5.Focus();
                }
                else
                {
                    textBox3.Focus();
                }

            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox5.Text.Length > 0)
                {
                    textBox4.Focus();
                }
                else
                {
                    textBox5.Focus();
                }

            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox4.Text.Length > 0)
                {
                    dateTimePicker1.Focus();
                }
                else
                {
                    textBox4.Focus();
                }

            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dateTimePicker1.Text.Length > 0)
                {
                    comboBox1.Focus();
                }
                else
                {
                    dateTimePicker1.Focus();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (Validation())
                {
                    if (IfUserNameExists(textBox2.Text))
                    {
                        MessageBox.Show("User Name already exists...!!!", "Polkotuwa Stores");

                    }
                    else
                    {



                        DialogResult dr = MessageBox.Show("Are you sure want to Save Record", "Polkotuwa Stores", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {

                            con1.dataSend1("insert into [dbo].[Login] (Name,USERNAME,PASSWORD,Address,Email,Dob,Role) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text + "','" + textBox3.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "','" + comboBox1.Text.ToString() + "')");
                            MessageBox.Show("Record Saved Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();


                        }

                        disp_data();
                    }
                }
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


                textBox1.Text = dataGridView1.SelectedRows[0].Cells["Full_Name"].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells["USERNAME"].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells["Address"].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells["Dob"].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells["Role"].Value.ToString();
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
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

                    con1.dataSend1("UPDATE Login SET Name ='" + textBox1.Text + "', PASSWORD ='" + textBox3.Text + "', Address ='" + textBox5.Text + "', Email ='" + textBox4.Text + "', Dob ='" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "', Role ='" + comboBox1.Text + "'where USERNAME='" + textBox2.Text + "'");
                    MessageBox.Show("Record Updated Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disp_data();
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;

                }
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


                DialogResult dr = MessageBox.Show("Are you sure want to Remove", "Polkotuwa Stores", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    con1.dataSend1("delete from [dbo].[Login] where USERNAME='" + textBox2.Text + "'");
                    MessageBox.Show("Record Removed Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disp_data();
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void budgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Budget_Page bp = new Budget_Page();
            bp.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Page bp = new Login_Page();
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
    }
}
