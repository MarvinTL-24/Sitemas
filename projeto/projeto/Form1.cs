namespace projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;

            if (usuario == "nomenclatura")
            {
                if (senha == "novasenha")
                {
                    Form2 janela = new Form2();
                    janela.Show();
                }
                else
                {
                    MessageBox.Show("A senha est� incorreta. Tente novamente!", "Erro de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("O usu�rio est� incorreto. Tente novamente!", "Erro de Usu�rio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
