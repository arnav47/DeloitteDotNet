using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBExt
{
    public partial class Form2 : Form
    {
        TrainingDBEntities db = new TrainingDBEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.RegisterShopping' table. You can move, or remove it, as needed.
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

        }

        private void btnregister_Click(object sender, EventArgs e)
        {

            string name = txtname.Text;

            string gender = cbgender.SelectedItem.ToString();

            string membership = "";
            if (rbfree.Checked)
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
            if (cbcod.Checked)
            {
                cod = "yes";

            }
            else
            {
                cod = "no";


            }



            string pass = txtpass.Text;



            MessageBox.Show(name + "\n" + gender + "\n" + membership + "  " + cod + "    " + pass);

            RegisterShopping rs = new RegisterShopping();
            rs.Name = name;
            rs.Gender = gender;
            rs.Membership = membership;
            rs.ShoppingPreference = shopping;
            rs.COD = cod;
            rs.Password = pass;
            db.RegisterShoppings.Add(rs);
            var res=db.SaveChanges(); 

            if (res>0)
                {
                MessageBox.Show("Data Inserted");
                this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);
            }
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            lbselect.Items.Clear();
            foreach(var t in db.RegisterShoppings)
            {
                lbselect.Items.Add(t.Id);
                lbselect.Items.Add(t.Name);
                lbselect.Items.Add(t.Gender);
                lbselect.Items.Add(t.Membership);
                lbselect.Items.Add(t.ShoppingPreference);
                lbselect.Items.Add(t.COD);
                lbselect.Items.Add(t.Password);

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = (int)cbid.SelectedValue;

            var del = (from t in db.RegisterShoppings
                       where t.Id == id
                       select t).SingleOrDefault();

            // var del= db.RegisterShoppings.Where(x=>x.Id==id).SingleOrDefault();

            db.RegisterShoppings.Remove(del);
            var res = db.SaveChanges();

            if(res>0)
            {
                MessageBox.Show("Data Deleted");
                this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string shopping = " ";
            foreach (var item in clbshop.CheckedItems)
            {
                shopping += item + " ";
            }


            string cod = "";
            if (cbcod.Checked)
            {
                cod = "yes";

            }
            else
            {
                cod = "no";


            }
            string membership = "";
            if (rbfree.Checked)
            {
                membership = rbfree.Text;
            }
            if (rbpaid.Checked)
            {
                membership = rbpaid.Text;
            }




            string pass = txtpass.Text;


            int id = (int)cbid.SelectedValue;
            var olddata = db.RegisterShoppings.Where(x => x.Id == id).SingleOrDefault();
            olddata.Membership = membership;
            olddata.ShoppingPreference = shopping;
            olddata.COD = cod;
            olddata.Password = pass;

            olddata.Id = id;

                var res = db.SaveChanges();

            if (res > 0)
            {
                MessageBox.Show("Data Updated");
                this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);
            }
        }

        private void btnsp_Click(object sender, EventArgs e)
        {
            int id = (int)cbid.SelectedValue;
            lbselect.Items.Clear();
            var res =  db.sp_SelectRegisterShopping(id);
            foreach (var r in res)
            {

                lbselect.Items.Add(r.Id);
                lbselect.Items.Add(r.Name);
                lbselect.Items.Add(r.Gender);
                lbselect.Items.Add(r.Membership);
                lbselect.Items.Add(r.ShoppingPreference);
                lbselect.Items.Add(r.COD);
                lbselect.Items.Add(r.Password);
            }
        }
    }
}
