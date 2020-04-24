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
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Show();
            User_Register_Page ss = new User_Register_Page();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Show();
            Attendence_And_Salary_Page ss = new Attendence_And_Salary_Page();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
           Stock_Page ss = new Stock_Page();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Show();
            Budget_Page ss = new Budget_Page();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Show();
            Billing_Page ss = new Billing_Page();
            ss.Show();
        }
        bool close = true;
        private void Home_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult dr = MessageBox.Show("Are you sure want to Exit", "Polkotuwa Stores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Billing_Page bp = new Billing_Page();
            bp.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Page bp = new Stock_Page();
            bp.Show();
        }

       

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Budget_Page bp = new Budget_Page();
            bp.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password_Page bp = new Change_Password_Page();
            bp.Show();
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

        private void employeeAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Register_Page bp = new Employee_Register_Page();
            bp.Show();
        }

       

       

       

      

        private void button6_Click(object sender, EventArgs e)
        {
            this.Show();
            Employee_Register_Page bp = new Employee_Register_Page();
            bp.Show();
        }

        private void employeeAttendenceAndSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendence_And_Salary_Page bp = new Attendence_And_Salary_Page();
            bp.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Show();
            Suplyer ss = new Suplyer();
            ss.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suplyer ss = new Suplyer();
            ss.Show();
        }
    }
}
