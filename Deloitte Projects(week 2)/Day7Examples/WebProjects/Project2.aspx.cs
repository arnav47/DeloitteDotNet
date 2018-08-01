using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProjects
{
    public partial class Project2 : System.Web.UI.Page
    {
        TrainingDBEntities db = new TrainingDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
        protected void b1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            GridViewRow r= (GridViewRow) b.NamingContainer;
            Response.Write(r.Cells[0] + " , " + r.Cells[1] + " , " + r.Cells[2]);
            int id = int.Parse(r.Cells[0].Text);
            var olddata = (from t in db.UserInfoes
                          where t.Id == id
                          select t).SingleOrDefault();
            olddata.status = "Active";
            olddata.Id = id;
            var res = db.SaveChanges();
            if(res>0)
            {
                Response.Write("Status Updated");
            }

        }
    }
}