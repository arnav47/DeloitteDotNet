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

namespace ADOE
{
    public partial class Form1 : Form
    {

        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;

        string constr = "Data Source=DESKTOP-HRT0I3F;Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.RegisterShopping' table. You can move, or remove it, as needed.
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblcod_Click(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;

            string gender = cbgender.SelectedItem.ToString();

            string membership = "";
            if(rbfree.Checked)
            {
                membership = rbfree.Text;
            }
            if (rbpaid.Checked)
            {
                membership = rbpaid.Text;
            }


            string shopping = " ";
            foreach (var item in clbshop.CheckedItems)
            {
                shopping += item + " ";
            }


            string cod = "";
            if(cbcod.Checked)
            {
                cod = "yes";

            }
            else
            {
                cod="no";


            }



            string pass = txtpass.Text;



            MessageBox.Show(name + "\n" + gender + "\n" + membership + "  " + cod + "    " + pass);

            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "insert into RegisterShopping values(@nm,@gen,@mem,@pref,@cod,@pwd)";//parameters to sql query
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", name);
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@mem", membership);
                cmd.Parameters.AddWithValue("@pref", shopping);
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.Parameters.AddWithValue("@pwd", pass);

                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    MessageBox.Show("Data Inserted: " + res);
                    this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);
                }
            }
            catch(SqlException sql)
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

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from RegisterShopping";

                cmd = new SqlCommand(query, con);
                r=cmd.ExecuteReader();
                lbselect.Items.Clear();

                while (r.Read())
                {
                    for(int i=0;i<r.FieldCount;i++)
                    {
                        lbselect.Items.Add(r[i]);
                        lbselect.Items.Add("++++++++++++");

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

        private void lbselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)cbid.SelectedValue;
                MessageBox.Show("ID is " + id);
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from RegisterShopping where ID=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    MessageBox.Show("Data deleted:" + res);
                    this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string membership =" ";
                if(rbpaid.Checked)
                {                                                                                                                                         
                    membership = rbpaid.Text;


                }
                if (rbfree.Checked)
                {
                    membership = rbfree.Text;
                 }

                string shop = " ";
                foreach(var s in clbshop.CheckedItems)
                {
                    shop += s + ",";
                }

                string pass = txtpass.Text;
                int id = (int)cbid.SelectedValue;
                con = new SqlConnection(constr);
                con.Open();
                string query = "update RegisterShopping set membership=@mem,ShoppingPref=@shop,Password=@pass where Id=@id";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@mem", membership);
                cmd.Parameters.AddWithValue("@shop", shop);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@id", id);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Data Updated:" + res);
                  
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
    }
}
