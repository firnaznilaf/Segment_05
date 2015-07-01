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

namespace Segment_05
{
    public partial class StudentDetails : Form
    {
        private string stdId;
        private string stdNme;
        private string stdDob;
        private double stdGpa;
        private string status;

        public StudentDetails()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        public StudentDetails(string stdId, string stdNme, string stdDob, double stdGpa, string status)
        {
            // TODO: Complete member initialization
            this.stdId = stdId;
            this.stdNme = stdNme;
            this.stdDob = stdDob;
            this.stdGpa = stdGpa;
            this.status = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {

        }

        public void LoadDataToGridView()
        {
            String connectionString = "Data Source=FIRNAZ-PC\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Pooling=False";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("ReadStudents", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentDetails");
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();

        }
        /**public void getDetailsToGridView() {

            dataGridView1.Rows.Add(stdId, stdNme, stdDob, stdGpa, status);
        }**/

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            RegisterStudent rs = new RegisterStudent();
            rs.MdiParent = this.MdiParent;
            rs.Show();
            this.Close();
            
        }
    }
}
