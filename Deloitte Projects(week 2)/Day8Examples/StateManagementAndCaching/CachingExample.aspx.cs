using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Caching; 
namespace StateManagementAndCaching
{
    
    public partial class CachingExample : System.Web.UI.Page
    {

        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con=new SqlConnection("Data Source=DESKTOP-HRT0I3F;Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False");
            adp = new SqlDataAdapter("select * from RegisterShopping", con);

            if (Cache["DataSet"] == null)
            {
                ds = new DataSet();

                adp.Fill(ds, "UserInfo");
                Cache.Add("data", ds, null, DateTime.Now.AddMinutes(2), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Default, null);


            }
            else
            {
                ds = (DataSet)Cache["data"];
                Label1.Text ="From Cache";

            }
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HRT0I3F;Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False");
            adp = new SqlDataAdapter("select * from RegisterShopping", con);

            if (Cache["DataSet"] == null)
            {
                ds = new DataSet();

                adp.Fill(ds, "UserInfo");
                Cache.Add("data", ds, null, DateTime.MaxValue , TimeSpan.FromMinutes(2) , System.Web.Caching.CacheItemPriority.Default, null);


            }
            else
            {
                ds = (DataSet)Cache["data"];
                Label1.Text = "From Cache";

            }
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HRT0I3F;Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False");
            adp = new SqlDataAdapter("select * from RegisterShopping", con);

            if (Cache["DataSet"] == null)
            {
                ds = new DataSet();

                adp.Fill(ds, "UserInfo");
                CacheDependency cd = new CacheDependency("@c:\\Files\data.txt");


                Cache.Add("data", ds, null, DateTime.MaxValue, TimeSpan.FromMinutes(2), System.Web.Caching.CacheItemPriority.Default, null);


            }
            else
            {
                ds = (DataSet)Cache["data"];
                Label1.Text = "From Cache";

            }
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
    }
    }
    