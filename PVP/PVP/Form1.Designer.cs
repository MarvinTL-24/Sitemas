namespace PVP
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
            this.TXT_TITULO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_ATQJ1 = new System.Windows.Forms.Button();
            this.BTN_DFJ1 = new System.Windows.Forms.Button();
            this.BTN_ATQJ2 = new System.Windows.Forms.Button();
            this.BTN_DFJ2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_TITULO
            // 
            this.TXT_TITULO.AutoSize = true;
            this.TXT_TITULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TITULO.Location = new System.Drawing.Point(166, 18);
            this.TXT_TITULO.Name = "TXT_TITULO";
            this.TXT_TITULO.Size = new System.Drawing.Size(322, 33);
            this.TXT_TITULO.TabIndex = 0;
            this.TXT_TITULO.Text = "PVP - 2 JOGADORES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "JOGADOR 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "JOGADOR 2";
            // 
            // BTN_ATQJ1
            // 
            this.BTN_ATQJ1.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ATQJ1.ForeColor = System.Drawing.Color.Crimson;
            this.BTN_ATQJ1.Location = new System.Drawing.Point(169, 216);
            this.BTN_ATQJ1.Name = "BTN_ATQJ1";
            this.BTN_ATQJ1.Size = new System.Drawing.Size(123, 43);
            this.BTN_ATQJ1.TabIndex = 3;
            this.BTN_ATQJ1.Text = "ATAQUE";
            this.BTN_ATQJ1.UseVisualStyleBackColor = true;
            this.BTN_ATQJ1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_DFJ1
            // 
            this.BTN_DFJ1.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DFJ1.ForeColor = System.Drawing.Color.Orange;
            this.BTN_DFJ1.Location = new System.Drawing.Point(169, 352);
            this.BTN_DFJ1.Name = "BTN_DFJ1";
            this.BTN_DFJ1.Size = new System.Drawing.Size(123, 43);
            this.BTN_DFJ1.TabIndex = 4;
            this.BTN_DFJ1.Text = "DEFESA";
            this.BTN_DFJ1.UseVisualStyleBackColor = true;
            // 
            // BTN_ATQJ2
            // 
            this.BTN_ATQJ2.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ATQJ2.ForeColor = System.Drawing.Color.Crimson;
            this.BTN_ATQJ2.Location = new System.Drawing.Point(476, 216);
            this.BTN_ATQJ2.Name = "BTN_ATQJ2";
            this.BTN_ATQJ2.Size = new System.Drawing.Size(123, 43);
            this.BTN_ATQJ2.TabIndex = 5;
            this.BTN_ATQJ2.Text = "ATAQUE";
            this.BTN_ATQJ2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTN_ATQJ2.UseVisualStyleBackColor = true;
            this.BTN_ATQJ2.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTN_DFJ2
            // 
            this.BTN_DFJ2.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DFJ2.ForeColor = System.Drawing.Color.Orange;
            this.BTN_DFJ2.Location = new System.Drawing.Point(476, 351);
            this.BTN_DFJ2.Name = "BTN_DFJ2";
            this.BTN_DFJ2.Size = new System.Drawing.Size(123, 43);
            this.BTN_DFJ2.TabIndex = 6;
            this.BTN_DFJ2.Text = "DEFESA";
            this.BTN_DFJ2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(215, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 29);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "100";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(522, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 29);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "100";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::PVP.Properties.Resources.pngwing_com__7_;
            this.pictureBox3.Location = new System.Drawing.Point(314, 190);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 248);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::PVP.Properties.Resources.pngwing_com__6_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTN_DFJ2);
            this.Controls.Add(this.BTN_ATQJ2);
            this.Controls.Add(this.BTN_DFJ1);
            this.Controls.Add(this.BTN_ATQJ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_TITULO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "P1 X P2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TXT_TITULO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_ATQJ1;
        private System.Windows.Forms.Button BTN_DFJ1;
        private System.Windows.Forms.Button BTN_ATQJ2;
        private System.Windows.Forms.Button BTN_DFJ2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

