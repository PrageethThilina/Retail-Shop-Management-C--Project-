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
    public partial class Suplyer : Form
    {
        string fileName;
        public Suplyer()
        {
            InitializeComponent();
        }
        Connection2 con2 = new Connection2();

        private bool Validation()
        {



            bool result = false;
            if (string.IsNullOrEmpty(txtID.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtID, "ID Required");
            }

            else if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtName, "Name Required");
            }

            else if (string.IsNullOrEmpty(txtConNum.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConNum, "Contact Number Required");
            }
            else if (string.IsNullOrEmpty(txtAdd.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAdd, "Address Required");
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
            txtID.Clear();
            txtName.Clear();

            txtConNum.Clear();
            txtAdd.Clear();
        }
        private void disp_data()
        {
            try
            {


                con2.dataGet2("select * from [dbo].[SupDetails]");
                DataTable dt = new DataTable();
                con2.sda2.Fill(dt);
                SupDetailGrid.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = SupDetailGrid.Rows.Add();
                    SupDetailGrid.Rows[n].Cells["SupID"].Value = row["SupID"].ToString();
                    SupDetailGrid.Rows[n].Cells["SupName"].Value = row["SupName"].ToString();
                    SupDetailGrid.Rows[n].Cells["SupConNum"].Value = row["SupNum"].ToString();
                    SupDetailGrid.Rows[n].Cells["SupAdd"].Value = row["SupAdd"].ToString();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


        private void Suplyer_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                if (Validation())
                {

                    

                        DialogResult dr = MessageBox.Show("Are you sure want to Save Record", "Polkotuwa Stores", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            Connection2 con2 = new Connection2();
                            con2.dataSend2("insert into [dbo].[SupDetails] (SupID,SupName,SupNum,SupAdd) values('" + txtID.Text.ToString() + "', '" + txtName.Text.ToString() + "', '" + txtConNum.Text.ToString() + "', '" + txtAdd.Text.ToString() + "')");
                            MessageBox.Show("Record Saved Successfully....!!!", "Polkotuwa Stores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();


                        }

                        disp_data();
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show("Are you sure want to Update", "Polkotuwa Stores", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    con2.dataSend2("UPDATE [dbo].[Employee_Register] SET SupID ='" + txtID.Text + "', SupName ='" + txtName.Text + "', SupNum ='" + txtConNum.Text + "', SupAdd ='" + txtAdd.Text + "' where SupIDId='" + txtID.Text + "'");


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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {



                DialogResult dr = MessageBox.Show("Are you sure want to Delete", "Polkotuwa Stores", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    con2.dataSend2("Delete From [dbo].[SupDetails] where SupID='" + txtID.Text + "'");


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
    }
}
