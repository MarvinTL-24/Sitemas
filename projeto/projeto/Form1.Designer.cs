namespace projeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTN_login = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // BTN_login
            // 
            BTN_login.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_login.Location = new Point(267, 319);
            BTN_login.Name = "BTN_login";
            BTN_login.Size = new Size(201, 50);
            BTN_login.TabIndex = 0;
            BTN_login.Text = "ENTRAR";
            BTN_login.UseVisualStyleBackColor = true;
            BTN_login.Click += BTN_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Square721 BT", 15.75F, FontStyle.Bold);
            label1.Location = new Point(123, 147);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Square721 BT", 15.75F, FontStyle.Bold);
            label2.Location = new Point(123, 227);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(230, 147);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(308, 23);
            txt_usuario.TabIndex = 3;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(230, 229);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(308, 23);
            txt_senha.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(310, 9);
            label3.Name = "label3";
            label3.Size = new Size(135, 50);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(726, 450);
            Controls.Add(label3);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BTN_login);
            Name = "Form1";
            Text = "Logar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_login;
        private Label label1;
        private Label label2;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Label label3;
    }
}
