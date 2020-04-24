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
    public partial class Billing_Page : Form
    {
        public Billing_Page()
        {
            InitializeComponent();
            fillcombobox();
          
        }
        Connection2 con2 = new Connection2();
        private void ClearData()
        {
            textBox10.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            

        }
       

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
           /* radioButton6.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;
            radioButton3.ForeColor = System.Drawing.Color.Green;
            radioButton4.ForeColor = System.Drawing.Color.Green;
            radioButton5.ForeColor = System.Drawing.Color.Green;*/

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            /*radioButton6.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Green;
            radioButton4.ForeColor = System.Drawing.Color.Green;
            radioButton5.ForeColor = System.Drawing.Color.Green;*/

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            /*radioButton6.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Green;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Green;
            radioButton5.ForeColor = System.Drawing.Color.Green;*/


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           /* radioButton6.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Green;
            radioButton3.ForeColor = System.Drawing.Color.Green;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Green;*/

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            /* radioButton6.ForeColor = System.Drawing.Color.Green;
             radioButton2.ForeColor = System.Drawing.Color.Green;
             radioButton3.ForeColor = System.Drawing.Color.Green;
             radioButton4.ForeColor = System.Drawing.Color.Green;
             radioButton5.ForeColor = System.Drawing.Color.Red;*/
           
        }
       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                textBox3.Text = (Convert.ToInt16(textBox10.Text) * Convert.ToInt16(textBox2.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=PRAGEETH\SQLEXPRESS;Initial Catalog=Stock_Db;Integrated Security=True");
                con.Open();
                string query = "update [dbo].[Stock] set Item_Quantity = Item_Quantity-'" + textBox2.Text + "'where Item_Name='" + comboBox1.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();


                string[] arr = new string[4];
                arr[0] = comboBox1.SelectedItem.ToString();
                arr[1] = textBox10.Text;
                arr[2] = textBox2.Text;
                arr[3] = textBox3.Text;

                ListViewItem lvi = new ListViewItem(arr);
                listView1.Items.Add(lvi);
                textBox4.Text = (Convert.ToInt16(textBox4.Text) + Convert.ToInt16(textBox3.Text)).ToString();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 0)
            {
                textBox6.Text = (Convert.ToInt16(textBox4.Text) - Convert.ToInt16(textBox5.Text)).ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length > 0)
            {
                textBox9.Text = (Convert.ToInt16(textBox7.Text) - Convert.ToInt16(textBox6.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                if (listView1.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Selected)
                        {
                            textBox4.Text = (Convert.ToInt16(textBox4.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                            listView1.Items[i].Remove();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Billing_Page_Load(object sender, EventArgs e)
        {

        }
        public void fillcombobox()
        {
            SqlConnection con = new SqlConnection(@"Data Source=PRAGEETH\SQLEXPRESS;Initial Catalog=Stock_Db;Integrated Security=True");
            string sql = "select * from [dbo].[Stock]";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while(myreader.Read())
                {
                    string Item_Name = myreader.GetString(1);
                    comboBox1.Items.Add(Item_Name);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PRAGEETH\SQLEXPRESS;Initial Catalog=Stock_Db;Integrated Security=True");
            string sql = "select * from [dbo].[Stock] where Item_Name = '"+comboBox1.Text+"';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string Item_Price = myreader.GetInt32(2).ToString();
                    textBox10.Text = Item_Price;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox10.Text.Length > 0)
                {
                    textBox2.Focus();
                }
                else
                {
                    textBox10.Focus();
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

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox5.Text.Length > 0)
                {
                    textBox7.Focus();
                }
                else
                {
                    textBox5.Focus();
                }

            }
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
        Bitmap bmp;
        private void button5_Click(object sender, EventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                con2.dataSend2("insert into [dbo].[Billing_Details] (Customer_Name,Date,Sub_Total,Discount,Net_Total,Paid,Balance) values ('" + textBox11.Text.ToString() + "','" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox9.Text.ToString() + "')");
                MessageBox.Show("Record Saved Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Show();
            Customer_Details bp = new Customer_Details();
            bp.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}




