namespace Capa_Presentacion
{
    partial class FormLogIn
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            tbEmail = new TextBox();
            tbPass = new TextBox();
            pbDoubleCheck = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDoubleCheck).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(45, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 197, 86);
            label1.Location = new Point(77, 128);
            label1.Name = "label1";
            label1.Size = new Size(138, 39);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.envelope_regular_24;
            pictureBox2.Location = new Point(24, 192);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.lock_alt_regular_241;
            pictureBox3.Location = new Point(24, 299);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 197, 86);
            panel1.Location = new Point(24, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 197, 86);
            panel2.Location = new Point(24, 330);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 197, 86);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(47, 65, 122);
            button1.Location = new Point(24, 357);
            button1.Name = "button1";
            button1.Size = new Size(236, 43);
            button1.TabIndex = 7;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.Control;
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.ForeColor = Color.FromArgb(47, 65, 122);
            tbEmail.Location = new Point(59, 199);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(187, 19);
            tbEmail.TabIndex = 8;
            // 
            // tbPass
            // 
            tbPass.BackColor = SystemColors.Control;
            tbPass.BorderStyle = BorderStyle.None;
            tbPass.Font = new Font("Impact", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbPass.ForeColor = Color.FromArgb(47, 65, 122);
            tbPass.Location = new Point(60, 303);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(186, 19);
            tbPass.TabIndex = 9;
            // 
            // pbDoubleCheck
            // 
            pbDoubleCheck.Image = Properties.Resources.check_double_regular_24;
            pbDoubleCheck.Location = new Point(252, 195);
            pbDoubleCheck.Name = "pbDoubleCheck";
            pbDoubleCheck.Size = new Size(30, 30);
            pbDoubleCheck.SizeMode = PictureBoxSizeMode.AutoSize;
            pbDoubleCheck.TabIndex = 12;
            pbDoubleCheck.TabStop = false;
            pbDoubleCheck.Visible = false;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(47, 65, 122);
            button2.Image = Properties.Resources.exit_regular_24;
            button2.Location = new Point(197, 414);
            button2.Name = "button2";
            button2.Size = new Size(81, 36);
            button2.TabIndex = 13;
            button2.Text = "Exit";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(47, 65, 122);
            button3.Image = Properties.Resources.format_clear_custom;
            button3.Location = new Point(24, 414);
            button3.Name = "button3";
            button3.Size = new Size(121, 36);
            button3.TabIndex = 15;
            button3.Text = "Clear Fields";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 454);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pbDoubleCheck);
            Controls.Add(tbPass);
            Controls.Add(tbEmail);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDoubleCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private TextBox tbEmail;
        private TextBox tbPass;
        private PictureBox pbDoubleCheck;
        private Button button2;
        private Button button3;
    }
}