using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckInProject
{
    public partial class Checkout : System.Web.UI.Page
    {
        VisitorDBEntities1 db = new VisitorDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var data = (from t in db.VisitorInfoes
                            where t.status == "Signed In"
                            select new { t.Id, t.Fname, t.Lname, t.IDType, t.IDNum }).ToList();


                GridView1.DataSource = data;
                GridView1.DataBind();
            }


           
           
        }

        protected void btnid_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtname.Text))
            {
                var data = db.VisitorInfoes.ToList();
                GridView1.DataSource = data;
                GridView1.DataBind();
            }

            else
            {
                int id = int.Parse(txtname.Text);
                    var data = (from t in db.VisitorInfoes
                                where t.Id == id && t.status == "Signed In"
                                select new { t.Id, t.Fname,t.Lname,t.IDType,t.IDNum}  ).ToList();

                if(data.Count()==0)
                {
                    Label1.Text = "Invalid Id";
                }
                else
                {
                    GridView1.DataSource = data;
                    GridView1.DataBind();
                }
            }
        }

        protected void btnname_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                var data = db.VisitorInfoes.ToList();
                GridView1.DataSource = data;
                GridView1.DataBind();
            }

            else
            {
                string name = txtname.Text ;
                var data1 = (from t in db.VisitorInfoes
                            where t.Fname == name && t.status == "Signed In"
                             select new { t.Id,t.Fname, t.Lname, t.IDType, t.IDNum }).ToList();

                if (data1.Count() == 0)
                {
                    Label1.Text = "Invalid Name";
                }
                else
                {
                    GridView1.DataSource = data1;
                    GridView1.DataBind();
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            GridViewRow r = (GridViewRow)b1.NamingContainer;

            int id = int.Parse( r.Cells[1].Text);

            var olddata = (from t in db.VisitorInfoes
                           where t.Id == id && t.status == "Signed In"
                           select t).SingleOrDefault();

            olddata.status = "Signed Out";

            var res = db.SaveChanges();
            if(res>0)
            {
                Response.Write("Status Updated");
                GridView1.DataBind();
            }

            var data = (from t in db.VisitorInfoes
                        where t.status == "Signed In"
                        select new { t.Id, t.Fname, t.Lname, t.IDType, t.IDNum }).ToList();


            GridView1.DataSource = data;
            GridView1.DataBind();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}