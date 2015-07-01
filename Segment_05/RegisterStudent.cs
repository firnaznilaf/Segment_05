using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segment_05
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string stdId = txtId.Text;
            string stdNme = txtName.Text;
            string stdDob = DOBPicker.Value.ToShortDateString();
            double stdGpa = Convert.ToDouble(txtGPA.Text);            
            string status = "";

            if (chkActive.Checked)
            {

                status = "Enrolled";
            }
            else 
            {
                status = "Not Enrolled";
            
            }

            StudentRgistration stdReg = new StudentRgistration();
            stdReg.registerStudent(stdId, stdNme, stdDob, stdGpa, status);

            StudentDetails std = new StudentDetails();
            std.MdiParent = this.MdiParent;
            std.Show();
            this.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentDetails std = new StudentDetails();
            std.MdiParent = this.MdiParent;
            std.Show();
            this.Close();
        }

        
    }
}
