namespace Database
{
    partial class create
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
            textBoxId = new TextBox();
            textBoxUsername = new TextBox();
            Save = new Button();
            textBoxAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(204, 172);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(200, 39);
            textBoxId.TabIndex = 0;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(204, 231);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(200, 39);
            textBoxUsername.TabIndex = 1;
            // 
            // Save
            // 
            Save.BackColor = Color.Blue;
            Save.ForeColor = Color.White;
            Save.Location = new Point(474, 165);
            Save.Name = "Save";
            Save.Size = new Size(150, 46);
            Save.TabIndex = 2;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += button1_Click;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(204, 297);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(200, 39);
            textBoxAge.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 175);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 231);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 5;
            label2.Text = "NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 304);
            label3.Name = "label3";
            label3.Size = new Size(57, 32);
            label3.TabIndex = 6;
            label3.Text = "AGE";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 399);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(798, 530);
            dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(474, 231);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 8;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
            button2.Location = new Point(474, 293);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaShell;
            button3.ForeColor = SystemColors.WindowFrame;
            button3.Location = new Point(663, 161);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 10;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button4.ForeColor = Color.Brown;
            button4.Location = new Point(663, 290);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 11;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(224, 224, 224);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(663, 224);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 12;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 35);
            label4.Name = "label4";
            label4.Size = new Size(522, 86);
            label4.TabIndex = 13;
            label4.Text = "Crud Operation";
            // 
            // create
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 998);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAge);
            Controls.Add(Save);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxId);
            Name = "create";
            Text = "create";
            Load += create_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private TextBox textBoxUsername;
        private Button Save;
        private TextBox textBoxAge;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label4;
    }
}