using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementAndCaching
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String n = Request.QueryString["v1"].ToString();
            int age = int.Parse(Request.QueryString["v2"].ToString());
            String em = Request.QueryString["v3"].ToString();

            Response.Write(n + "<br/>" + age + "<br/>" + em + "<br/>");


        }
    }
}