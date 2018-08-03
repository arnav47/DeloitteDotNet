using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client1
{
    
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int card = int.Parse(txtCard.Text);
            string cvv = txtCVV.Text;
            decimal amt = decimal.Parse(txtAmount.Text);

            try
            {
                ServiceReference3.CardClient cc = new ServiceReference3.CardClient();
                var c = cc.Authenticate(card, cvv);
                if(c)
                {
                    MessageBox.Show("Login successful");

                }
                else
                {
                    MessageBox.Show("Login unsuccessful");
                }

                var d = cc.DateCheck(card);
                if(d)
                {
                    MessageBox.Show("Card still Valid");

                }
                else
                {
                    MessageBox.Show("Card Expired");
                }
                var f = cc.Trans(card, amt);
                if (c && d)
                {
                    MessageBox.Show("Your Balance is" + f);

                }
         

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
    }
}
