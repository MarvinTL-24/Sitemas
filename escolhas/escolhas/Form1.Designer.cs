namespace escolhas
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
            TXT_1 = new TextBox();
            TXT_2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LABEL3 = new Label();
            CBX_operador = new ComboBox();
            label4 = new Label();
            TXT_RESULTADO = new TextBox();
            BTN_CALCULAR = new Button();
            SuspendLayout();
            // 
            // TXT_1
            // 
            TXT_1.Font = new Font("Yu Gothic", 12F);
            TXT_1.Location = new Point(117, 61);
            TXT_1.Name = "TXT_1";
            TXT_1.Size = new Size(138, 33);
            TXT_1.TabIndex = 1;
            TXT_1.TextAlign = HorizontalAlignment.Center;
            TXT_1.TextChanged += TXT_1_TextChanged;
            // 
            // TXT_2
            // 
            TXT_2.Font = new Font("Yu Gothic", 12F);
            TXT_2.Location = new Point(117, 111);
            TXT_2.Name = "TXT_2";
            TXT_2.Size = new Size(138, 33);
            TXT_2.TabIndex = 2;
            TXT_2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F);
            label1.Location = new Point(24, 61);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 3;
            label1.Text = "VALOR 1 -";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F);
            label2.Location = new Point(24, 111);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 4;
            label2.Text = "VALOR 2 -";
            // 
            // LABEL3
            // 
            LABEL3.AutoSize = true;
            LABEL3.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL3.Location = new Point(41, 9);
            LABEL3.Name = "LABEL3";
            LABEL3.Size = new Size(192, 25);
            LABEL3.TabIndex = 5;
            LABEL3.Text = "CALCULADORA -IF";
            // 
            // CBX_operador
            // 
            CBX_operador.Font = new Font("Yu Gothic", 12F);
            CBX_operador.FormattingEnabled = true;
            CBX_operador.Items.AddRange(new object[] { "soma", "subtração", "multiplicação", "divisão" });
            CBX_operador.Location = new Point(117, 167);
            CBX_operador.Name = "CBX_operador";
            CBX_operador.Size = new Size(138, 29);
            CBX_operador.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F);
            label4.Location = new Point(7, 167);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 7;
            label4.Text = "OPERAÇÃO -";
            // 
            // TXT_RESULTADO
            // 
            TXT_RESULTADO.Font = new Font("Yu Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TXT_RESULTADO.Location = new Point(41, 275);
            TXT_RESULTADO.Name = "TXT_RESULTADO";
            TXT_RESULTADO.Size = new Size(183, 84);
            TXT_RESULTADO.TabIndex = 9;
            TXT_RESULTADO.TextAlign = HorizontalAlignment.Center;
            TXT_RESULTADO.TextChanged += textBox3_TextChanged;
            // 
            // BTN_CALCULAR
            // 
            BTN_CALCULAR.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_CALCULAR.Location = new Point(41, 229);
            BTN_CALCULAR.Name = "BTN_CALCULAR";
            BTN_CALCULAR.Size = new Size(183, 40);
            BTN_CALCULAR.TabIndex = 10;
            BTN_CALCULAR.Text = "CALCULAR";
            BTN_CALCULAR.UseVisualStyleBackColor = true;
            BTN_CALCULAR.Click += BTN_CALCULAR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 387);
            Controls.Add(BTN_CALCULAR);
            Controls.Add(TXT_RESULTADO);
            Controls.Add(label4);
            Controls.Add(CBX_operador);
            Controls.Add(LABEL3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TXT_2);
            Controls.Add(TXT_1);
            Name = "Form1";
            Text = "IF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXT_1;
        private TextBox TXT_2;
        private Label label1;
        private Label label2;
        private Label LABEL3;
        private ComboBox CBX_operador;
        private Label label4;
        private TextBox TXT_RESULTADO;
        private Button BTN_CALCULAR;
    }
}
