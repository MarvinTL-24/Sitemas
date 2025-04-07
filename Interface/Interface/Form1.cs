namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CINEMA");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PREÇO: ");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("QUANTIDADE: ");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("TOTAL: ");
        }

        private void BTN_CALCULAR_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(TXT_PREÇO.Text);
            double quantidade = Convert.ToDouble(TXT_QTD.Text); 

            double total = preco * quantidade;
            TXT_TOTAL.Text = total.ToString();
        }
    }
}
