namespace WinForm.UserDefinefunction
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 1;
            label1.Text = "ชื่อ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 52);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 34);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 3;
            label2.Text = "ต้องไม่ตํ่ากว่า 2 ตัวอักษร";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 200);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 4;
            label3.Text = "ชื่อบัญชีผู้ใช้";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(231, 194);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 34);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 267);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 6;
            label4.Text = "รหัสผ่าน";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(231, 261);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(290, 34);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(231, 329);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(290, 34);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 335);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 9;
            label5.Text = "ยืนยันรหัสผ่าน";
            // 
            // button1
            // 
            button1.Location = new Point(286, 410);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(169, 77);
            button1.TabIndex = 10;
            button1.Text = "สมัครสมาชิก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 200);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 28);
            label6.TabIndex = 11;
            label6.Text = "มีได้ไม่เกิน 20 ตัว";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(550, 267);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(166, 28);
            label7.TabIndex = 12;
            label7.Text = "ไม่ตํ่ากว่า 8 ตัวอักษร";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(550, 127);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(194, 28);
            label8.TabIndex = 15;
            label8.Text = "ต้องไม่ตํ่ากว่า 2 ตัวอักษร";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(231, 121);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(290, 34);
            textBox5.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(122, 124);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(77, 28);
            label9.TabIndex = 13;
            label9.Text = "นามสกุล";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1100, 630);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
    }
}
