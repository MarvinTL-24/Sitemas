namespace Interface
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
            label1 = new Label();
            TXT_PREÇO = new TextBox();
            TXT_QTD = new TextBox();
            TXT_TOTAL = new TextBox();
            BTN_CALCULAR = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Wide Latin", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 0;
            label1.Text = "CINEMA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // TXT_PREÇO
            // 
            TXT_PREÇO.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TXT_PREÇO.Location = new Point(142, 102);
            TXT_PREÇO.Name = "TXT_PREÇO";
            TXT_PREÇO.Size = new Size(206, 33);
            TXT_PREÇO.TabIndex = 1;
            // 
            // TXT_QTD
            // 
            TXT_QTD.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TXT_QTD.Location = new Point(142, 174);
            TXT_QTD.Name = "TXT_QTD";
            TXT_QTD.Size = new Size(206, 33);
            TXT_QTD.TabIndex = 2;
            // 
            // TXT_TOTAL
            // 
            TXT_TOTAL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TXT_TOTAL.Location = new Point(142, 368);
            TXT_TOTAL.Name = "TXT_TOTAL";
            TXT_TOTAL.Size = new Size(206, 33);
            TXT_TOTAL.TabIndex = 3;
            // 
            // BTN_CALCULAR
            // 
            BTN_CALCULAR.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_CALCULAR.Location = new Point(142, 242);
            BTN_CALCULAR.Name = "BTN_CALCULAR";
            BTN_CALCULAR.Size = new Size(206, 79);
            BTN_CALCULAR.TabIndex = 4;
            BTN_CALCULAR.Text = "CALCULAR";
            BTN_CALCULAR.UseVisualStyleBackColor = true;
            BTN_CALCULAR.Click += BTN_CALCULAR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Square721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(216, 79);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 5;
            label2.Text = "PREÇO:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Square721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(189, 151);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 6;
            label3.Text = "QUANTIDADE:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Square721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(189, 345);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 7;
            label4.Text = "VALOR TOTAL:";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(488, 461);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BTN_CALCULAR);
            Controls.Add(TXT_TOTAL);
            Controls.Add(TXT_QTD);
            Controls.Add(TXT_PREÇO);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TXT_PREÇO;
        private TextBox TXT_QTD;
        private TextBox TXT_TOTAL;
        private Button BTN_CALCULAR;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
