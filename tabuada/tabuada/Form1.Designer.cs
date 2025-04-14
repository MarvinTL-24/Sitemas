namespace tabuada
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BTNMAIS = new System.Windows.Forms.Button();
            this.BTNMENOS = new System.Windows.Forms.Button();
            this.BTNVEZES = new System.Windows.Forms.Button();
            this.BTNDIVIDIR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_RESULTADO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABUADA - INTERATIVA";
            // 
            // BTNMAIS
            // 
            this.BTNMAIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMAIS.Location = new System.Drawing.Point(106, 111);
            this.BTNMAIS.Name = "BTNMAIS";
            this.BTNMAIS.Size = new System.Drawing.Size(74, 44);
            this.BTNMAIS.TabIndex = 1;
            this.BTNMAIS.Text = "+";
            this.BTNMAIS.UseVisualStyleBackColor = true;
            this.BTNMAIS.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNMENOS
            // 
            this.BTNMENOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMENOS.Location = new System.Drawing.Point(186, 111);
            this.BTNMENOS.Name = "BTNMENOS";
            this.BTNMENOS.Size = new System.Drawing.Size(74, 44);
            this.BTNMENOS.TabIndex = 2;
            this.BTNMENOS.Text = "-";
            this.BTNMENOS.UseVisualStyleBackColor = true;
            this.BTNMENOS.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNVEZES
            // 
            this.BTNVEZES.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVEZES.Location = new System.Drawing.Point(266, 111);
            this.BTNVEZES.Name = "BTNVEZES";
            this.BTNVEZES.Size = new System.Drawing.Size(74, 44);
            this.BTNVEZES.TabIndex = 3;
            this.BTNVEZES.Text = "*";
            this.BTNVEZES.UseVisualStyleBackColor = true;
            this.BTNVEZES.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTNDIVIDIR
            // 
            this.BTNDIVIDIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDIVIDIR.Location = new System.Drawing.Point(346, 111);
            this.BTNDIVIDIR.Name = "BTNDIVIDIR";
            this.BTNDIVIDIR.Size = new System.Drawing.Size(74, 44);
            this.BTNDIVIDIR.TabIndex = 4;
            this.BTNDIVIDIR.Text = "/";
            this.BTNDIVIDIR.UseVisualStyleBackColor = true;
            this.BTNDIVIDIR.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "VALOR DESEJAVEL -";
            // 
            // TXT_1
            // 
            this.TXT_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_1.Location = new System.Drawing.Point(217, 67);
            this.TXT_1.Name = "TXT_1";
            this.TXT_1.Size = new System.Drawing.Size(242, 29);
            this.TXT_1.TabIndex = 6;
            this.TXT_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "RESULTADO";
            // 
            // LBL_RESULTADO
            // 
            this.LBL_RESULTADO.AutoSize = true;
            this.LBL_RESULTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RESULTADO.Location = new System.Drawing.Point(12, 239);
            this.LBL_RESULTADO.Name = "LBL_RESULTADO";
            this.LBL_RESULTADO.Size = new System.Drawing.Size(0, 24);
            this.LBL_RESULTADO.TabIndex = 8;
            this.LBL_RESULTADO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(489, 567);
            this.Controls.Add(this.LBL_RESULTADO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNDIVIDIR);
            this.Controls.Add(this.BTNVEZES);
            this.Controls.Add(this.BTNMENOS);
            this.Controls.Add(this.BTNMAIS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNMAIS;
        private System.Windows.Forms.Button BTNMENOS;
        private System.Windows.Forms.Button BTNVEZES;
        private System.Windows.Forms.Button BTNDIVIDIR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_RESULTADO;
    }
}

