using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIIS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);

            try
            {
                ServiceReference1.IcalculatorClient cc = new ServiceReference1.IcalculatorClient();
                var add = cc.Add(n, m);
                var sub = cc.Sub(n, m);

                MessageBox.Show("Addition is " + add);
                MessageBox.Show("Subtraction is " + sub);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);

            try
            {
                ServiceReference2.IcalculatorClient cc = new ServiceReference2.IcalculatorClient();
                var add = cc.Add(n, m);
                var sub = cc.Sub(n, m);

                MessageBox.Show("Addition is " + add);
                MessageBox.Show("Subtraction is " + sub);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
