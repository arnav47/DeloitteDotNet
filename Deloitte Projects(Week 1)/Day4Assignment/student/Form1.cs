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

namespace student
{
    public partial class Form : System.Windows.Forms.Form


    {

        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;

        string constr = "Data Source=DESKTOP-HRT0I3F;Initial Catalog=StudentDB;Integrated Security=True;Pooling=False";

        public Form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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


            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "insert into StudentInfo values(@rn,@nm,@dob,@gen,@dep,@cou,@sem,@add,@phn)";//parameters to sql query
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@rn", RollNo);
                cmd.Parameters.AddWithValue("@nm", Name);
                cmd.Parameters.AddWithValue("@dob", DOB);
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@dep", Department);
                cmd.Parameters.AddWithValue("@cou", Course);
                cmd.Parameters.AddWithValue("@sem", Sem);
                cmd.Parameters.AddWithValue("@add", Address);
                cmd.Parameters.AddWithValue("@phn", PhoneNo);


                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Data Inserted: " + res);

                }
                else
                {
                    MessageBox.Show("Error.");
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from StudentInfo";

                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                lbsel.Items.Clear();

                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbsel.Items.Add(r[i]);
                        lbsel.Items.Add("++++++++++++");

                    }
                }

            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

        }
    



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtName.Text;
                DateTime DOB = DateTime.Parse(dtpDOB.Text.ToString());

               
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



                int RollNo = (int)(cbroll.SelectedValue);
                MessageBox.Show("Roll no. is " + RollNo);

                con = new SqlConnection(constr);

                con.Open();

                string query = "Update StudentInfo set name=@name,DOB=@DOB,Gender=@gender,Department=@dept,Course=@crs,Semester=@sem,Address=@add,PhoneNo=@phn where RollNo=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", RollNo);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dept", Department);
                cmd.Parameters.AddWithValue("@crs", Course);
                cmd.Parameters.AddWithValue("@sem", Sem);
                cmd.Parameters.AddWithValue("@add", Address);
                cmd.Parameters.AddWithValue("@phn", PhoneNo);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Data Updated:" + res);
                    this.studentInfoTableAdapter.Fill(this.studentDBDataSet.StudentInfo);
                }

            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int RollNo = (int)(cbroll.SelectedValue);
                MessageBox.Show("Roll no. is " + RollNo);
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from StudentInfo where RollNo=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", RollNo);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Data deleted:" + res);
                    this.studentInfoTableAdapter.Fill(this.studentDBDataSet.StudentInfo);
                }

                }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

        }

        private void txtRoll_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPh_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.studentDBDataSet.StudentInfo);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbsel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbroll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentInfoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
