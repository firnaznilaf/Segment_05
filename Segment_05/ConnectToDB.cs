using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Segment_05
{

    class ConnectToDB
    {
     
        public static SqlConnection myCon = null;

        public void CreateConnection()
        {
            myCon = new SqlConnection("Data Source=FIRNAZ-PC\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Pooling=False");
            

        }
    }
}
