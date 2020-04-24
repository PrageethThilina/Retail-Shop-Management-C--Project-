using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class Connection2
    {
        public SqlConnection con2;
        public SqlCommand cmd2;
        public SqlDataAdapter sda2;
        public string pkk2;

        public void connection2()
        {
            con2 = new SqlConnection(@"Data Source=PRAGEETH\SQLEXPRESS;Initial Catalog=Stock_Db;Integrated Security=True");
            con2.Open();
        }
        public void dataSend2(string SQL2)
        {
            try
            {
                connection2();
                cmd2 = new SqlCommand(SQL2, con2);
                cmd2.ExecuteNonQuery();
                pkk2 = "";
            }
            catch (Exception)
            {
                pkk2 = "Please Check Your Data";
            }
            con2.Close();
        }
        public void dataGet2(string SQL2)
        {
            try
            {
                connection2();
                sda2 = new SqlDataAdapter(SQL2, con2);
            }
            catch (Exception)
            {

            }
        }
    }
}
