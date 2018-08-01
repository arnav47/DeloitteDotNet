using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckInProject
{
    public partial class CheckIn : System.Web.UI.Page
    {

        VisitorDBEntities1 db = new VisitorDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string Fname = txtfname.Text;
            string Lname = txtlname.Text;
            string comp = txtcomp.Text;
            string vis = txtvis.Text;
            string idType = " ";
            idType = ddlid.SelectedValue.ToString();
            string idNum = txtidno.Text;
            string vehicle = txtvehicle.Text;
            string con = txtcon.Text;
            string pov = txtpov.Text;



            Response.Write("Visitor entered: " + Fname + Lname);

            VisitorInfo vi = new VisitorInfo();
            vi.Fname = Fname;
            vi.Lname = Lname;
            vi.Company = comp;
            vi.Visiting = vis;
            vi.IDType = idType;
            vi.Purpose = pov;
            vi.VNum = vehicle;
            vi.Contact = con;
            vi.IDNum = idNum;
            vi.status = "Signed In";
            vi.time = DateTime.Now;

            db.VisitorInfoes.Add(vi);
            var res = db.SaveChanges();

            if (res>0)
            {
                Response.Write("Visitor saved: " + Fname + Lname + "Time:" + vi.time);
            }
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            txtfname.Text=" ";
            txtlname.Text = " ";
            txtcomp.Text = " ";
            txtvis.Text = " ";

            txtidno.Text = " ";
            txtvehicle.Text = " ";
            txtcon.Text = " ";
            txtpov.Text = " ";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}