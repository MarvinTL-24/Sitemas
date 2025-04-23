namespace projeto
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 40);
            label1.Name = "label1";
            label1.Size = new Size(373, 45);
            label1.TabIndex = 0;
            label1.Text = "BEM VINDO USUÁRIO!!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(180, 155);
            label2.Name = "label2";
            label2.Size = new Size(428, 32);
            label2.TabIndex = 1;
            label2.Text = "ESCOLHA O QUE DESEJA VISUALIZAR:";
            // 
            // button1
            // 
            button1.Location = new Point(47, 240);
            button1.Name = "button1";
            button1.Size = new Size(156, 40);
            button1.TabIndex = 2;
            button1.Text = "EDITORES";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(47, 338);
            button2.Name = "button2";
            button2.Size = new Size(156, 40);
            button2.TabIndex = 3;
            button2.Text = "BEATMAKER'S";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(47, 435);
            button3.Name = "button3";
            button3.Size = new Size(156, 40);
            button3.TabIndex = 4;
            button3.Text = "CANTORES";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(354, 240);
            button4.Name = "button4";
            button4.Size = new Size(142, 40);
            button4.TabIndex = 5;
            button4.Text = "MIXER'S";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(354, 338);
            button5.Name = "button5";
            button5.Size = new Size(142, 40);
            button5.TabIndex = 6;
            button5.Text = "ILUSTRADORES";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(354, 435);
            button6.Name = "button6";
            button6.Size = new Size(142, 40);
            button6.TabIndex = 7;
            button6.Text = "THUMBMAKER'S";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(629, 435);
            button7.Name = "button7";
            button7.Size = new Size(142, 40);
            button7.TabIndex = 10;
            button7.Text = "REACT'S";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(629, 338);
            button8.Name = "button8";
            button8.Size = new Size(142, 40);
            button8.TabIndex = 9;
            button8.Text = "FEAT'S";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(629, 240);
            button9.Name = "button9";
            button9.Size = new Size(142, 40);
            button9.TabIndex = 8;
            button9.Text = "RECORTADORES";
            button9.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(831, 630);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form2";
            Text = "Bem Vindo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}