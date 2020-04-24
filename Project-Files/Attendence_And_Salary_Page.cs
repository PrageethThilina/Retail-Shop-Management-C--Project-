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
using System.IO;

namespace Group_Project
{
    public partial class Attendence_And_Salary_Page : Form
    {
        public Attendence_And_Salary_Page()
        {
            InitializeComponent();
        }
      
        // Attendence Part

        private void ClearData1()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        

        }
      

        private DataGridView dgview;
        private DataGridViewTextBoxColumn dgviewcol1;
        private DataGridViewTextBoxColumn dgviewcol2;
        void Search()
        {
            try
            {


                dgview = new DataGridView();
                dgviewcol1 = new DataGridViewTextBoxColumn();
                dgviewcol2 = new DataGridViewTextBoxColumn();
                this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dgview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgviewcol1, this.dgviewcol2 });
                this.dgview.Name = "dgview";
                dgview.Visible = false;
                this.dgviewcol1.Visible = false;
                this.dgviewcol2.Visible = false;
                this.dgview.AllowUserToAddRows = false;
                this.dgview.RowHeadersVisible = false;
                this.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                //this.dgview.KeyDown = new System.Windows.Forms.KeyEventHandler(this.dgview_KeyDown);

                this.Controls.Add(dgview);
                this.dgview.ReadOnly = true;
                dgview.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Two Columns

        void Search(int LX, int LY, int DW, int DH, string ColName, String ColSize)
        {
            try
            {


                this.dgview.Location = new System.Drawing.Point(LX, LY);
                this.dgview.Size = new System.Drawing.Size(DW, DH);
                string[] ClSize = ColSize.Split(',');
                //Size
                for (int i = 0; i < ClSize.Length; i++)
                {
                    if (int.Parse(ClSize[i]) != 0)
                    {
                        dgview.Columns[i].Width = int.Parse(ClSize[i]);
                    }
                    else
                    {
                        dgview.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                //Name
                string[] ClName = ColName.Split(',');

                for (int i = 0; i < ClName.Length; i++)
                {
                    this.dgview.Columns[i].HeaderText = ClName[i];
                    this.dgview.Columns[i].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Attendence_And_Salary_Page_Load(object sender, EventArgs e)
        {
            Search();
            this.ActiveControl = textBox5;
            disp_data();
            disp1_data();
            disp_data2();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (textBox5.Text.Length > 0)
                {
                    this.dgview.Visible = true;
                    dgview.BringToFront();
                    Search(90, 70, 400, 200, "Emp Id,Emp Name", "100,0");
                    this.dgview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.employee_MouseDoubleClick);
                    Connection3 con3 = new Connection3();
                    con3.dataGet3("Select Top(10) EmpId,Name From [dbo].[Employee_Register] where EmpId like '" + textBox5.Text + "%'");
                    DataTable dt = new DataTable();
                    con3.sda3.Fill(dt);
                    dgview.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        int n = dgview.Rows.Add();
                        dgview.Rows[n].Cells[0].Value = row["EmpId"].ToString();
                        dgview.Rows[n].Cells[1].Value = row["Name"].ToString();

                    }
                }
                else
                {
                    dgview.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        bool change = true;

        private void employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {


                if (change)
                {
                    change = false;
                    textBox5.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                    textBox6.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                    this.dgview.Visible = false;
                    comboBox1.Focus();
                    change = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {


                if (e.KeyCode == Keys.Enter)
                {
                    if (dgview.Rows.Count > 0)
                    {
                        textBox5.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                        textBox6.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                        this.dgview.Visible = false;
                        comboBox1.Focus();
                    }
                    else
                    {
                        this.dgview.Visible = false;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        Connection3 con3 = new Connection3();
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (comboBox2.SelectedIndex != -1)
                {
                    con3.dataGet3("select * from [dbo].[EmpAttendence] where EmpId = '" + textBox1.Text + "'and Year='" + comboBox1.Text + "'and Month='" + comboBox2.Text + "'");
                    DataTable dt = new DataTable();
                    con3.sda3.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        textBox1.Text = dt.Rows[0]["TotalDays"].ToString();
                        textBox2.Text = dt.Rows[0]["WorkingDays"].ToString();
                        textBox3.Text = dt.Rows[0]["PresentDays"].ToString();
                        textBox4.Text = dt.Rows[0]["AbsentDays"].ToString();
                       

                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                       

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearData1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                
               
                con3.dataSend3("insert into [dbo].[EmpAttendence]  (EmpId,Name,Year,Month,TotalDays,WorkingDays,PresentDays,AbsentDays) values ('" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')"); 
                MessageBox.Show("Saved Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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

                    con3.dataSend3("UPDATE [dbo].[EmpAttendence] SET PresentDays ='" + textBox3.Text + "', AbsentDays ='" + textBox4.Text + "', TotalDays ='" + textBox1.Text + "', WorkingDays ='" + textBox2.Text +  "', Year ='" + comboBox1.Text + "', Month ='" + comboBox2.Text + "'");
                    MessageBox.Show("Updated Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dr = MessageBox.Show("Are you sure want to Delete", "Polkotuwa Stores", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    con3.dataSend3("delete [dbo].[EmpAttendence] where  EmpId ='" + textBox5.Text + "', Year ='" + comboBox1.Text + "', Month ='" + comboBox2.Text + "'");
                    MessageBox.Show("Deleted Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void disp_data()
        {
            try
            {


                con3.dataGet3("select * from [dbo].[EmpAttendence]"); //where Year='"+comboBox1.Text+"Month='"+comboBox2.Text+"'");
                DataTable dt = new DataTable();
                con3.sda3.Fill(dt);
                foreach (DataRow row in dt.Rows) 
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["EmpID"].Value = row["EmpId"].ToString();
                    dataGridView1.Rows[n].Cells["EmpName"].Value = row["Name"].ToString();
                    dataGridView1.Rows[n].Cells["Year"].Value = row["Year"].ToString();
                    dataGridView1.Rows[n].Cells["Month"].Value = row["Month"].ToString();
                    dataGridView1.Rows[n].Cells["TotalDays"].Value = row["TotalDays"].ToString();
                    dataGridView1.Rows[n].Cells["WorkingDays"].Value = row["WorkingDays"].ToString();
                    dataGridView1.Rows[n].Cells["PresentDays"].Value = row["PresentDays"].ToString();
                    dataGridView1.Rows[n].Cells["AbsentDays"].Value = row["AbsentDays"].ToString();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void disp1_data()
        {
            try
            {


                con3.dataGet3("select * from [dbo].[EmpAttendence]"); //where Year='"+comboBox1.Text+"Month='"+comboBox2.Text+"'");
                DataTable dt = new DataTable();
                con3.sda3.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["EmpID"].Value = row["EmpId"].ToString();
                    dataGridView1.Rows[n].Cells["EmpName"].Value = row["Name"].ToString();
                    dataGridView1.Rows[n].Cells["Year"].Value = row["Year"].ToString();
                    dataGridView1.Rows[n].Cells["Month"].Value = row["Month"].ToString();
                    dataGridView1.Rows[n].Cells["TotalDays"].Value = row["TotalDays"].ToString();
                    dataGridView1.Rows[n].Cells["WorkingDays"].Value = row["WorkingDays"].ToString();
                    dataGridView1.Rows[n].Cells["PresentDays"].Value = row["PresentDays"].ToString();
                    dataGridView1.Rows[n].Cells["AbsentDays"].Value = row["AbsentDays"].ToString();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            disp1_data();
        }

        

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {


                textBox5.Text = dataGridView1.SelectedRows[0].Cells["EmpID"].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells["EmpName"].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells["Year"].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells["Month"].Value.ToString();               
                textBox1.Text = dataGridView1.SelectedRows[0].Cells["TotalDays"].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells["WorkingDays"].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells["PresentDays"].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells["AbsentDays"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Salary Part

        private void ClearData2()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }

        private void disp_data2()
        {
            try
            {


                con3.dataGet3("select * from [dbo].[EmpSalary] EmployeeName ='"+textBox6.Text + "'");
                DataTable dt = new DataTable();
                con3.sda3.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells["EmployeeID"].Value = row["EmpId"].ToString();
                    dataGridView2.Rows[n].Cells["EmployeeName"].Value = row["Name"].ToString();
                    dataGridView2.Rows[n].Cells["Year_"].Value = row["Year"].ToString();
                    dataGridView2.Rows[n].Cells["Month_"].Value = row["Month"].ToString();
                    dataGridView2.Rows[n].Cells["PerDaySalary"].Value = row["PerDaySalary"].ToString();
                    dataGridView2.Rows[n].Cells["TotalSalary"].Value = row["TotalSalary"].ToString();
                    dataGridView2.Rows[n].Cells["Deductions"].Value = row["Deductions"].ToString();
                    dataGridView2.Rows[n].Cells["NetSalary"].Value = row["NetSalary"].ToString();
                    dataGridView2.Rows[n].Cells["TotalEmployeeSalary"].Value = row["TotalEmployeeSalary"].ToString();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {


                textBox8.Text = (Convert.ToInt16(textBox7.Text) * Convert.ToInt16(textBox2.Text)).ToString();
                textBox10.Text = (Convert.ToInt16(textBox8.Text) - Convert.ToInt16(textBox9.Text)).ToString();
                con3.dataGet3("select SUM(TotalEmployeeSalary) from [dbo].[EmpSalary] where Year='" + comboBox1.Text + "Month='" + comboBox2.Text + "'");
                DataTable dt = new DataTable();
                con3.sda3.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    textBox11.Text= row["TotalEmployeeSalary"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearData2();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {

                con3.dataSend3(@"insert into [dbo].[EmpSalary] (EmpId,Name,Year,Month,PerDaySalary,TotalSalary,Deductions,NetSalary,TotalEmployeeSalary) values ('" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + "')");

                MessageBox.Show("Saved Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disp_data2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure want to Update", "Polkotuwa Stores", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    con3.dataSend3("UPDATE [dbo].[EmpSalary] SET PerDaySalary ='" + textBox7.Text + "', TotalSalary ='" + textBox8.Text + "', Deductions ='" + textBox9.Text + "', NetSalary='" + textBox10.Text + "', TotalEmployeeSalary ='" + textBox11.Text  + "'");
                    MessageBox.Show("Updated Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dr = MessageBox.Show("Are you sure want to Delete", "Polkotuwa Stores", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    con3.dataSend3("delete [dbo].[EmpSalary] where  EmpId ='" + textBox5.Text + "', Year ='" + comboBox1.Text + "', Month ='" + comboBox2.Text + "'");
                    MessageBox.Show("Deleted Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {


                textBox5.Text = dataGridView2.SelectedRows[0].Cells["EmpID"].Value.ToString();
                textBox6.Text = dataGridView2.SelectedRows[0].Cells["Name"].Value.ToString();
                comboBox1.Text = dataGridView2.SelectedRows[0].Cells["Year"].Value.ToString();
                comboBox2.Text = dataGridView2.SelectedRows[0].Cells["Month"].Value.ToString();
                textBox7.Text = dataGridView2.SelectedRows[0].Cells["PerDaySalary"].Value.ToString();
                textBox8.Text = dataGridView2.SelectedRows[0].Cells["TotalSalary"].Value.ToString();
                textBox9.Text = dataGridView2.SelectedRows[0].Cells["Deductions"].Value.ToString();
                textBox10.Text = dataGridView2.SelectedRows[0].Cells["NetSalary"].Value.ToString();
                textBox11.Text = dataGridView2.SelectedRows[0].Cells["TotalEmployeeSalary"].Value.ToString();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);
            int y = int.Parse(textBox11.Text);

            int z = x * y;
            textBox10.Text = z.ToString();

            int m = int.Parse(textBox9.Text);
            int Deduction = z - m;
            textBox8.Text = Deduction.ToString();
            textBox7.Text = Deduction.ToString();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            try
            {

                con3.dataSend3("insert into [dbo].[EmpSalary]  (EmpId,Name,Year,Month,PerDaySalary,TotalSalary,Deductions,NetSalary,TotalEmployeeSalary) values ('" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox11.Text.ToString() + "','" + textBox10.Text.ToString() + "','" + textBox9.Text.ToString() + "','" + textBox8.Text.ToString() + "','" + textBox7.Text.ToString() + "')");
                MessageBox.Show("Saved Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            disp_data2();
        }
    }
    }
    


