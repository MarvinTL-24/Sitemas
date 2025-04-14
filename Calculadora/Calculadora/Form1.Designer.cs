namespace Calculadora
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
            Label VALOR;
            TXT_calculadora = new Label();
            BTN_SOMA = new Button();
            BTN_MENOS = new Button();
            BTN_VEZES = new Button();
            BTN_DIVIDIR = new Button();
            TXT_FINAL = new TextBox();
            label1 = new Label();
            label3 = new Label();
            TXT_V1 = new TextBox();
            TXT_V2 = new TextBox();
            VALOR = new Label();
            SuspendLayout();
            // 
            // VALOR
            // 
            VALOR.AutoSize = true;
            VALOR.BackColor = Color.Transparent;
            VALOR.Font = new Font("Swis721 BT", 12F, FontStyle.Bold);
            VALOR.Location = new Point(88, 68);
            VALOR.Name = "VALOR";
            VALOR.Size = new Size(87, 19);
            VALOR.TabIndex = 16;
            VALOR.Text = "VALOR 1 -";
            // 
            // TXT_calculadora
            // 
            TXT_calculadora.AutoSize = true;
            TXT_calculadora.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TXT_calculadora.ImageAlign = ContentAlignment.TopCenter;
            TXT_calculadora.Location = new Point(97, 9);
            TXT_calculadora.Margin = new Padding(0);
            TXT_calculadora.Name = "TXT_calculadora";
            TXT_calculadora.Padding = new Padding(10);
            TXT_calculadora.Size = new Size(173, 43);
            TXT_calculadora.TabIndex = 0;
            TXT_calculadora.Text = "CALCULADORA";
            TXT_calculadora.TextAlign = ContentAlignment.TopCenter;
            // 
            // BTN_SOMA
            // 
            BTN_SOMA.Font = new Font("Square721 BT", 12F, FontStyle.Bold);
            BTN_SOMA.Location = new Point(12, 159);
            BTN_SOMA.Name = "BTN_SOMA";
            BTN_SOMA.Size = new Size(84, 46);
            BTN_SOMA.TabIndex = 10;
            BTN_SOMA.Text = "+";
            BTN_SOMA.UseVisualStyleBackColor = true;
            BTN_SOMA.Click += BTN_SOMA_Click;
            // 
            // BTN_MENOS
            // 
            BTN_MENOS.Font = new Font("Square721 BT", 12F, FontStyle.Bold);
            BTN_MENOS.Location = new Point(99, 159);
            BTN_MENOS.Name = "BTN_MENOS";
            BTN_MENOS.Size = new Size(84, 46);
            BTN_MENOS.TabIndex = 11;
            BTN_MENOS.Text = "-";
            BTN_MENOS.UseVisualStyleBackColor = true;
            BTN_MENOS.Click += BTN_MENOS_Click;
            // 
            // BTN_VEZES
            // 
            BTN_VEZES.Font = new Font("Square721 BT", 12F, FontStyle.Bold);
            BTN_VEZES.Location = new Point(186, 159);
            BTN_VEZES.Name = "BTN_VEZES";
            BTN_VEZES.Size = new Size(84, 46);
            BTN_VEZES.TabIndex = 12;
            BTN_VEZES.Text = "X";
            BTN_VEZES.UseVisualStyleBackColor = true;
            BTN_VEZES.Click += BTN_VEZES_Click;
            // 
            // BTN_DIVIDIR
            // 
            BTN_DIVIDIR.Font = new Font("Square721 BT", 12F, FontStyle.Bold);
            BTN_DIVIDIR.Location = new Point(273, 159);
            BTN_DIVIDIR.Name = "BTN_DIVIDIR";
            BTN_DIVIDIR.Size = new Size(84, 46);
            BTN_DIVIDIR.TabIndex = 13;
            BTN_DIVIDIR.Text = "/";
            BTN_DIVIDIR.UseVisualStyleBackColor = true;
            BTN_DIVIDIR.Click += BTN_DIVIDIR_Click;
            // 
            // TXT_FINAL
            // 
            TXT_FINAL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TXT_FINAL.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TXT_FINAL.Location = new Point(45, 247);
            TXT_FINAL.Name = "TXT_FINAL";
            TXT_FINAL.Size = new Size(270, 93);
            TXT_FINAL.TabIndex = 14;
            TXT_FINAL.TextAlign = HorizontalAlignment.Center;
            TXT_FINAL.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(128, 217);
            label1.Name = "label1";
            label1.Size = new Size(131, 27);
            label1.TabIndex = 15;
            label1.Text = "RESULTADO";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 BT", 12F, FontStyle.Bold);
            label3.Location = new Point(88, 107);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 17;
            label3.Text = "VALOR 2 -";
            // 
            // TXT_V1
            // 
            TXT_V1.Font = new Font("Segoe UI", 14.25F);
            TXT_V1.Location = new Point(181, 60);
            TXT_V1.Name = "TXT_V1";
            TXT_V1.Size = new Size(78, 33);
            TXT_V1.TabIndex = 18;
            TXT_V1.TabStop = false;
            TXT_V1.TextAlign = HorizontalAlignment.Center;
            TXT_V1.TextChanged += TXT_V1_TextChanged;
            // 
            // TXT_V2
            // 
            TXT_V2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TXT_V2.Font = new Font("Segoe UI", 14.25F);
            TXT_V2.Location = new Point(181, 99);
            TXT_V2.Name = "TXT_V2";
            TXT_V2.Size = new Size(78, 33);
            TXT_V2.TabIndex = 19;
            TXT_V2.TabStop = false;
            TXT_V2.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(368, 347);
            Controls.Add(TXT_V2);
            Controls.Add(TXT_V1);
            Controls.Add(label3);
            Controls.Add(VALOR);
            Controls.Add(label1);
            Controls.Add(TXT_FINAL);
            Controls.Add(BTN_DIVIDIR);
            Controls.Add(BTN_VEZES);
            Controls.Add(BTN_MENOS);
            Controls.Add(BTN_SOMA);
            Controls.Add(TXT_calculadora);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TXT_calculadora;
        private Button BTN_SOMA;
        private Button BTN_MENOS;
        private Button BTN_VEZES;
        private Button BTN_DIVIDIR;
        private TextBox TXT_FINAL;
        private Label label1;
        private Label label3;
        private TextBox TXT_V1;
        private TextBox TXT_V2;
    }
}
