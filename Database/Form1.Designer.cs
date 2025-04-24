namespace Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            cancel = new Button();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 689);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LavenderBlush;
            label3.Location = new Point(7, 282);
            label3.Name = "label3";
            label3.Size = new Size(450, 32);
            label3.TabIndex = 7;
            label3.Text = "BELTEI INTERNATIONAL UNIVERSITY";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(989, 151);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(458, 71);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(707, 177);
            label1.Name = "label1";
            label1.Size = new Size(163, 45);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(707, 290);
            label2.Name = "label2";
            label2.Size = new Size(153, 45);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(989, 264);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(458, 71);
            textBox2.TabIndex = 3;
            // 
            // cancel
            // 
            cancel.Location = new Point(1273, 492);
            cancel.Name = "cancel";
            cancel.Size = new Size(154, 68);
            cancel.TabIndex = 5;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(1044, 492);
            button1.Name = "button1";
            button1.Size = new Size(154, 68);
            button1.TabIndex = 6;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Crimson;
            label4.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label4.ForeColor = Color.LavenderBlush;
            label4.Location = new Point(1036, 41);
            label4.Name = "label4";
            label4.Size = new Size(229, 59);
            label4.TabIndex = 8;
            label4.Text = "REGISTER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(707, 397);
            label5.Name = "label5";
            label5.Size = new Size(276, 45);
            label5.TabIndex = 10;
            label5.Text = "Confirm Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(989, 371);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(458, 71);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 689);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(cancel);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button cancel;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
    }
}
