namespace WinForm.UserDefinefunction
{
    partial class Form3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 70);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 0;
            label1.Text = "กรอกตัวอักษร 1 ตัว";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 125);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 1;
            label2.Text = "กำหนดขนาด";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 34);
            textBox1.TabIndex = 2;
            textBox1.Text = "x";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 34);
            textBox2.TabIndex = 3;
            textBox2.Text = "5";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 188);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(464, 430);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(525, 64);
            button1.Name = "button1";
            button1.Size = new Size(87, 99);
            button1.TabIndex = 5;
            button1.Text = "GO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(398, 55);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 32);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "แบบที่ 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(398, 93);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 32);
            radioButton2.TabIndex = 7;
            radioButton2.Text = "แบบที่ 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(398, 131);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(93, 32);
            radioButton3.TabIndex = 8;
            radioButton3.Text = "แบบที่ 3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(712, 630);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}