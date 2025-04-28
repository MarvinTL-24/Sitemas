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
                    this.Hide(); // Oculta o Form1
                    Form2 janela = new Form2();
                    DialogResult resultado = janela.ShowDialog(); // Abre Form2 de forma modal

                    if (resultado == DialogResult.OK)
                    {
                        this.Show(); // Retorna para o Form1
                    }
                    else
                    {
                        this.Close(); // Encerra o programa, ou outra ação
                    }
                }
                else
                {
                    MessageBox.Show("A senha está incorreta. Tente novamente!", "Erro de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("O usuário está incorreto. Tente novamente!", "Erro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
