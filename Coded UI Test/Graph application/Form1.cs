using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графическое_приложение
{
    public partial class Form1 : Form
    {
        public static double p;
        public static double a;
        public static double s;
        public static double sos;
        public static double v,h,h1;
        public Form1()
        {
           
            InitializeComponent();
            label7.Text = "";
            label8.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a= Convert.ToDouble(textBox1.Text);
            h= Convert.ToDouble(textBox2.Text);
            p = 0.5 * 3 * a;
            s = Math.Round(p * h,2);
            label7.Text = Convert.ToString(s);
            sos =  a * a * Math.Sqrt(3) / 4/3;
            h1= Convert.ToDouble(textBox3.Text);
            v =Math.Round(sos* h1,2);
            label8.Text = Convert.ToString(v);
        }
    }
}
