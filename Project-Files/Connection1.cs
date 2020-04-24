using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class Connection1
    {
        public SqlConnection con1;
        public SqlCommand cmd1;
        public SqlDataAdapter sda1;
        public string pkk1;

        public void connection1()
        {
            con1 = new SqlConnection(@"Data Source=PRAGEETH\SQLEXPRESS;Initial Catalog=pt_login_now;Integrated Security=True");
            con1.Open();
        }
        public void dataSend1(string SQL1)
        {
            try
            {
                connection1();
                cmd1 = new SqlCommand(SQL1, con1);
                cmd1.ExecuteNonQuery();
                pkk1 = "";
            }
            catch (Exception)
            {
                pkk1 = "Please Check Your Data";
            }
            con1.Close();
        }
        public void dataGet1(string SQL1)
        {
            try
            {
                connection1();
                sda1 = new SqlDataAdapter(SQL1, con1);
            }
            catch (Exception)
            {

            }
        }
    }
}
