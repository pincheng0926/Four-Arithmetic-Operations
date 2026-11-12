namespace WinFormsApp2
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("標楷體", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(511, 286);
            button1.Name = "button1";
            button1.Size = new Size(203, 68);
            button1.TabIndex = 0;
            button1.Text = "確定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox1.Location = new Point(22, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 54);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(22, 55);
            label1.Name = "label1";
            label1.Size = new Size(152, 65);
            label1.TabIndex = 2;
            label1.Text = "整數1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(211, 55);
            label2.Name = "label2";
            label2.Size = new Size(171, 61);
            label2.TabIndex = 3;
            label2.Text = "運算子";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微軟正黑體", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(420, 55);
            label3.Name = "label3";
            label3.Size = new Size(151, 61);
            label3.TabIndex = 4;
            label3.Text = "整數2";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox2.Location = new Point(222, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 54);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox3.Location = new Point(420, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 54);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft JhengHei UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(22, 286);
            label4.Name = "label4";
            label4.Size = new Size(405, 80);
            label4.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(764, 402);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
    }
}
