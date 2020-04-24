using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class Connection3
    {
        public SqlConnection con3;
        public SqlCommand cmd3;
        public SqlDataAdapter sda3;
        public string pkk3;

        public void connection3()
        {
            con3 = new SqlConnection(@"Data Source=PRAGEETH\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
            con3.Open();
        }
        public void dataSend3(string SQL3)
        {
            try
            {
                connection3();
                cmd3 = new SqlCommand(SQL3, con3);
                cmd3.ExecuteNonQuery();
                pkk3 = "";
            }
            catch(Exception)
            {
                pkk3 = "Please Check Your Data";
            }
            con3.Close();
        }
        public void dataGet3(string SQL3)
        {
            try
            {
                connection3();
                sda3 = new SqlDataAdapter(SQL3, con3);
            }
            catch(Exception)
            {

            }
        }

       
    }
}
