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
using WMPLib;

namespace Group_Project
{
    public partial class Login_Page : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Login_Page()
        {
            InitializeComponent();
            player.URL = "pt.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to Exit", "Polkotuwa Stores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection(@"Data Source=PRAGEETH\SQLEXPRESS;Initial Catalog=pt_login_now;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From [dbo].[Login] where USERNAME='" + textBox1.Text + "'and PASSWORD='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Show();
                    Main_Page ss = new Main_Page();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Please Check your username and Password", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void Login_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
            Change_Password_Page ss = new Change_Password_Page();
            ss.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
