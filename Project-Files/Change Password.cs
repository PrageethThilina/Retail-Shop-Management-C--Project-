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
    public partial class Change_Password_Page : Form
    {
        public Change_Password_Page()
        {
            InitializeComponent();
        }
        Connection1 con1 = new Connection1();
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

        private void Change_Password_Page_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dr = MessageBox.Show("Are you sure want to Update", "Polkotuwa Stores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    con1.dataGet1("select 1 from [dbo].[Login] where USERNAME = '" + textBox1.Text + "'and PASSWORD = '" + textBox2.Text + "'");
                    DataTable dt = new DataTable();
                    con1.sda1.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        if (textBox3.Text == textBox4.Text)
                        {
                            if (textBox3.Text.Length > 3)
                            {

                                con1.dataSend1("UPDATE [dbo].[Login] SET PASSWORD ='" + textBox3.Text + "'where USERNAME ='" + textBox1.Text + "'and PASSWORD ='" + textBox2.Text + "'");
                                MessageBox.Show("Record Updated Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                errorProvider1.SetError(textBox3, "Please enter minimum 4 caracters");

                            }
                        }
                        else
                        {
                            errorProvider1.SetError(textBox3, "Password Mismatch");
                            errorProvider1.SetError(textBox4, "Password Mismatch");
                        }
                    }

                    else
                    {
                        errorProvider1.SetError(textBox4, "Please check username and password");
                        errorProvider1.SetError(textBox4, "Please check username and password");


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
