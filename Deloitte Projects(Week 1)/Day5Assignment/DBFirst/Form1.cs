using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirst
{
    public partial class Form1 : Form
    {
        StudentDBEntities db = new StudentDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.studentDBDataSet.StudentInfo);

        }

        private void txtRoll_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int RollNo = int.Parse(txtRoll.Text);
            string Name = txtName.Text;
            DateTime DOB = DateTime.Parse(dtpDOB.Text.ToString());

            //string DOB = dtpDOB.Text;
            string gender = " ";
            if (rbMale.Checked)
            {
                gender = rbMale.Text;
            }
            if (rbFemale.Checked)
            {
                gender = rbFemale.Text;
            }

            string Department = cbDept.SelectedItem.ToString();
            string Course = cbCourse.SelectedItem.ToString();
            string Sem = cbSem.SelectedItem.ToString();

            string Address = txtAdd.Text;
            string PhoneNo = txtPh.Text;

            MessageBox.Show("Roll No: " + RollNo);

            StudentInfo si = new StudentInfo();
            si.RollNo = RollNo;
            si.Name = Name;
            si.DOB = DOB;
            si.Gender = gender;
            si.Department = Department;
            si.Course = Course;
            si.Semester = Sem;
            si.Address = Address;
            si.PhoneNo = PhoneNo;

            db.StudentInfoes.Add(si);

            var res = db.SaveChanges();
            if (res > 0)
            {

                MessageBox.Show("Data inserted");
            }




        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            lbsel.Items.Clear();

            foreach (var t in db.StudentInfoes)
            {
                lbsel.Items.Add(t.RollNo);
                lbsel.Items.Add(t.Name);
                lbsel.Items.Add(t.DOB);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)cbroll.SelectedValue;
            var del = (from t in db.StudentInfoes
                      where t.RollNo == id
                      select t).SingleOrDefault();

            db.StudentInfoes.Remove(del);

            var res = db.SaveChanges();

            if (res > 0)
            {

                MessageBox.Show("Data Deleted");
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
