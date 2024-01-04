using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_connected_en
{
    internal class productclass
    {
        string strcon = "server=TNL21885300-B\\SQLEXPRESS;integrated security=true;database=prodd;";
        //creating a method to insert record in student table
        public string InsertProduct(int prodid, string prodname, int price)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "insert into product values(@prodid,@prodname,@price)";
                using (SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@prodid", prodid);
                    command.Parameters.AddWithValue("@prodname", prodname);
                    command.Parameters.AddWithValue("@price", price);


                    command.ExecuteNonQuery();
                    con.Close();
                    return "record saved successfully";


                }

            }
        }
        public string UpdateProduct(int prodid, string prodname, int price)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "update product set prodid=@prodid,prodname=@prodname,price=@price where prodid=@prodid";
                using (SqlCommand command = new SqlCommand(str, con))
                {
                  
                    command.Parameters.AddWithValue("@prodname", prodname);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@prodid", prodid);

                    command.ExecuteNonQuery();
                    con.Close();
                    return "record update successfully";


                }

            }
        }

        public string DeleteProduct(int prodid)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "delete from product where prodid=@prodid";
                using (SqlCommand command = new SqlCommand(str, con))
                {

                    command.Parameters.AddWithValue("@prodid", prodid);

                    command.ExecuteNonQuery();
                    con.Close();
                    return "record delete successfully";


                }

            }
        }


    }
}

        //method to update record
       
