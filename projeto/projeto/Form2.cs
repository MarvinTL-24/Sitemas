using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            beatmaker janela = new beatmaker();
            janela.Show()
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editores janela = new editores();
            janela.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cantores janela = new cantores();
            janela.Show()
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mix janela = new mix();
            janela.Show()
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ilustradores janela = new ilustradores();
            janela.Show()
        }

        private void button6_Click(object sender, EventArgs e)
        {
            thumbmaker janela = new thumbmaker();
            janela.Show()
        }

        private void button9_Click(object sender, EventArgs e)
        {
            recortadores janela = new recortadores();
            janela.Show()
        }

        private void button8_Click(object sender, EventArgs e)
        {
            feat janela = new feat();
            janela.Show()
        }

        private void button7_Click(object sender, EventArgs e)
        {
            react janela = new react();
            janela.Show()
        }
    }
}
