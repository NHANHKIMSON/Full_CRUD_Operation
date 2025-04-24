namespace Database
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            cancel = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-42, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 689);
            panel1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LavenderBlush;
            label3.Location = new Point(7, 333);
            label3.Name = "label3";
            label3.Size = new Size(450, 32);
            label3.TabIndex = 7;
            label3.Text = "BELTEI INTERNATIONAL UNIVERSITY";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Crimson;
            label4.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label4.ForeColor = Color.LavenderBlush;
            label4.Location = new Point(992, 37);
            label4.Name = "label4";
            label4.Size = new Size(229, 59);
            label4.TabIndex = 18;
            label4.Text = "REGISTER";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(1000, 385);
            button1.Name = "button1";
            button1.Size = new Size(154, 68);
            button1.TabIndex = 17;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            // 
            // cancel
            // 
            cancel.Location = new Point(1229, 385);
            cancel.Name = "cancel";
            cancel.Size = new Size(154, 68);
            cancel.TabIndex = 16;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(663, 286);
            label2.Name = "label2";
            label2.Size = new Size(153, 45);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(945, 260);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(458, 71);
            textBox2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(663, 173);
            label1.Name = "label1";
            label1.Size = new Size(163, 45);
            label1.TabIndex = 13;
            label1.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(945, 147);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(458, 71);
            textBox1.TabIndex = 12;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 698);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(cancel);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Button button1;
        private Button cancel;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
    }
}