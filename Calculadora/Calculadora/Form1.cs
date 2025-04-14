namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_SOMA_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(TXT_V1.Text);
            double n2 = Convert.ToDouble(TXT_V2.Text);
            double resultado = n1 + n2;
            TXT_FINAL.Text = resultado.ToString();
        }

        private void TXT_V1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTN_MENOS_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(TXT_V1.Text);
            double n2 = Convert.ToDouble(TXT_V2.Text);
            double resultado = n1 - n2;
            TXT_FINAL.Text = resultado.ToString();
        }

        private void BTN_VEZES_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(TXT_V1.Text);
            double n2 = Convert.ToDouble(TXT_V2.Text);
            double resultado = n1 * n2;
            TXT_FINAL.Text = resultado.ToString();
        }

        private void BTN_DIVIDIR_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(TXT_V1.Text);
            double n2 = Convert.ToDouble(TXT_V2.Text);
            double resultado = n1 / n2;
            TXT_FINAL.Text = resultado.ToString();
        }
    }
}
