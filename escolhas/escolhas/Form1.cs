using Microsoft.VisualBasic;

namespace escolhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_CALCULAR_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(TXT_1.Text);
            double n2 = Convert.ToDouble(TXT_2.Text);
            string operador = CBX_operador.Text;
            
            if (operador == "soma")
            {
                TXT_RESULTADO.Text = Convert.ToString(n1 + n2);
            }else if (operador == "subtra��o")
            {
                TXT_RESULTADO.Text = Convert.ToString(n1 - n2);
            }else if (operador == "multiplica��o")
            {
                TXT_RESULTADO.Text = Convert.ToString(n1 * n2);
            }else if (operador == "divis�o")
            {
                TXT_RESULTADO.Text = Convert.ToString(n1 / n2);
            }else
            {
                TXT_RESULTADO.Text = Convert.ToString("ERRO");
            }
        }
    }
}
