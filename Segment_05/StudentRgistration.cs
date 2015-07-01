using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Segment_05
{
    class StudentRgistration
    {
        private String ConnectionString = "Data Source=FIRNAZ-PC\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Pooling=False";

        public void registerStudent(string studentID, string studentName, string dateOBirth, double GPA, string status)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("RegisterStudent", conn);
                    
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = studentID;
            cmd.Parameters.Add("@FullName", SqlDbType.VarChar).Value = studentName;
            cmd.Parameters.Add("@DOB", SqlDbType.VarChar).Value = dateOBirth;
            cmd.Parameters.Add("@GPA", SqlDbType.Decimal).Value = GPA;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = status;

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
               
            }
    }
}
