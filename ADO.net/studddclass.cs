using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace studdd
{
    class student
    {
        public int rno { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string hobby { get; set; }
        public string city { get; set; }
        public string dob { get; set; }

        public student(int rno, string name, string gender, string hobby, string city, string dob)
        {
            this.rno = rno;
            this.name = name;
            this.gender = gender;
            this.hobby = hobby;
            this.city = city;
            this.dob = dob;
        }
    }



        class studddclass
    {
        string strcon = "server=TNL21885300-B\\SQLEXPRESS;integrated " +
            "security=true;database=studdd;";
        //creating a method to insert record in student table

        public string InserStudent (int rno , string name , string gender , string hobby, string city , string dob)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                con.Open ();
                string str = "insert into studdd values(@rno,@name ,@gender, @hobby , @city ,@dob)";

                using (SqlCommand command=new SqlCommand (str,con)) 
                {
                    command.Parameters.AddWithValue ("@rno", rno);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@hobby", hobby);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@dob", dob);

                    command.ExecuteNonQuery();
                    con.Close ();
                    MessageBox.Show("add");
                    return "record save successfully";
                }
            }
        }

        public string UpdateStudent (int rno, string name, string gender, string hobby, string city, string dob)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "Update studdd set name=@name,gender=@gender,hobby=@hobby,city=@city,dob=@dob where rno=@rno";

                using (SqlCommand command = new SqlCommand(str, con))
                {
                   
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@hobby", hobby);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@dob", dob);
                    command.Parameters.AddWithValue("@rno", rno);

                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("update");
                    return "record update successfully";
                }
            }
        }

        public string DeleteStudent(int rno, string name)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "delete from studdd where rno=@rno or  name=@name";

                using (SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@rno", rno);
                    command.Parameters.AddWithValue("@name", name);



                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete");
                    return "record Delete successfully";
                }
            }
        }

        public List<student> searchstudent(int rno)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "select *from studdd where rno=@rno ";

                using (SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@rno", rno);
                    SqlDataReader reader;
                    reader=command.ExecuteReader();

                    List<student> li=new List<student>();   

                    while (reader.Read())
                    {
                        li.Add(new student(Convert.ToInt32(reader["rno"].ToString() ), reader["name"].ToString(),
                            reader["gender"].ToString(), reader["hobby"].ToString(), reader["city"].ToString(),
                            reader["dob"].ToString()));
                    }
                  reader.Close();
                  return li;
                    con.Close() ;

                }
            }
        }
    }
}                                                                                                                                                                                   
