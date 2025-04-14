using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(TXT_1.Text);
            LBL_RESULTADO.Text = ""; 

            for (int i = 0; i < 10; i++)
            {
                LBL_RESULTADO.Text += N.ToString() + " + 1 = " + (N + 1).ToString() + Environment.NewLine;
                N = 1;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double N = Convert.ToDouble(TXT_1.Text);
            LBL_RESULTADO.Text = "";
            for (int i = 0; i < 10; i++)
            {
                LBL_RESULTADO.Text += N.ToString() + " - 1 = " + (N + 1).ToString() + Environment.NewLine;
                N = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double N = Convert.ToDouble(TXT_1.Text);
            LBL_RESULTADO.Text = "";
            for (int i = 0; i < 10; i++)
            {
                LBL_RESULTADO.Text = N.ToString() + " - 1 =" + (N + 1).ToString() + "\n";
                N = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double N = Convert.ToDouble(TXT_1.Text);
            LBL_RESULTADO.Text = "";
            for (int i = 0; i < 10; i++)
            {
                LBL_RESULTADO.Text = N.ToString() + " * 1 =" + (N + 1).ToString() + "\n";
                N = 1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
