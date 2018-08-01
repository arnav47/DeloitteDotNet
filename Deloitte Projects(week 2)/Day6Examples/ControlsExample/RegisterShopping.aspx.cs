using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsExample
{
    public partial class RegisterShopping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string pass = txtpass.Text;

            string gender = ddlgender.SelectedItem.Text;

            string membership = "";
            if(rbfree.Checked)
            {
                membership = rbfree.Text;
            }
            if (rbpaid.Checked)
            {
                membership = rbpaid.Text;
            }

            string prefer = "";

            foreach(ListItem li in cblshopping.Items)
            {
                if(li.Selected)
                {
                    prefer += li.Text + ", ";

                }
            } 


            string cod = "";
            if(cbcod.Checked )
            {
                cod = "Yes";

            }
            else
            {
                cod = "No";

            }


            Label1.Text = name + "<br/> " + gender + "<br/> " + membership + "<br/> " + prefer + "<br/> " + cod + "<br/> " + pass;






        }

        protected void cblshopping_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}