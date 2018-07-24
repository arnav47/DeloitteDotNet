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

namespace day5
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        string constr = "Data Source=DESKTOP-HRT0I3F;Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.RegisterShopping' table. You can move, or remove it, as needed.
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                string query = "select * from RegisterShopping";
                adp = new SqlDataAdapter(query, con);
                ds = new DataSet();
                adp.Fill(ds, "Shop");
                SqlCommandBuilder builder = new SqlCommandBuilder(adp);
                adp.InsertCommand= builder.GetInsertCommand();
                adp.UpdateCommand = builder.GetUpdateCommand();
                adp.DeleteCommand = builder.GetDeleteCommand();
                //MessageBox.Show(adp.InsertCommand.CommandText);
               // MessageBox.Show(adp.UpdateCommand.CommandText);
                //MessageBox.Show(adp.DeleteCommand.CommandText);

                dgselect.DataSource = ds.Tables["Shop"];
                    
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
            int res = adp.Update(ds.Tables["Shop"]);
            if (res>0)
            {
                MessageBox.Show("Data Updated from DS to DB");

            }
            else { }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ds.GetXml());
        }

        private void btncall_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand
                    ("sp_SelectRegisterShopping", con);
                cmd.CommandType = CommandType.StoredProcedure;
                int id = int.Parse(txtid.Text);
                cmd.Parameters.AddWithValue("@id",id);

                var r = cmd.ExecuteReader();
                if(r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                        lbxml.Items.Add(r[i]);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
