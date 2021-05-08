using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_3laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combo_b.Items.Add("1.1");
            combo_b.Items.Add("5.5");
            combo_b.Items.Add("18.81");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double z = 0;
            float x = float.Parse(textBox_x.Text);
            
            
            double result = 0;


            switch (combo_b.SelectedIndex)
            {
                case 0: b = 1.1; break;
                case 1: b = 5.5; break;
                case 2: b = 18.81; break;

            }

            if (a1.Checked)
                a = 0.1;
            
            if (a2.Checked)
                a = 1.2;
            
            if (a_3.Checked)
                a = 3.3;
            


            if (z1.Checked == true)
            {
                z = Math.Pow(Math.Log(a), x);
            }
            if (z2.Checked == true)
            {
                double x2 = Math.Pow(x, 2);
                z = Math.Pow(Math.Log(b), x);
            }
            if (z3.Checked == true)
            {
                double ab = a * b;
                z = Math.Pow(Math.Log(ab), x);
            }

            if (x < a)
            {
                double bx = x * b;
                double x2 = Math.Pow(x, 2);
                double sin1 = Math.Sin(bx);
                result = a+Math.Sin(bx)+Math.Cos(x2);
                result_label.Text = result.ToString();


            }

            if (Math.Log(b) > x & x > a)
            {
                double xz = x * z;
                double bx = b * x;
                double n = a + bx;
                double f = Math.Sqrt(n);
                result = f + Math.Sin(xz);
                result_label.Text = result.ToString();

            }
            
            

            if (x > Math.Log(b))
            {
                double bx = b * x;
                double g = a + bx + z;
                result = Math.Sqrt(g);

                result_label.Text = result.ToString();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
