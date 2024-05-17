namespace Capa_Presentacion
{
    partial class FormAltaEmpleado
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbManager = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            cbStore = new ComboBox();
            groupBox1 = new GroupBox();
            pbOjo = new PictureBox();
            cbPrefijos = new ComboBox();
            tbTelefono = new TextBox();
            tbEmail = new TextBox();
            tbApellidos = new TextBox();
            tbPass = new TextBox();
            tbNombre = new TextBox();
            groupBox2 = new GroupBox();
            btnBorrar = new Button();
            pictureBox1 = new PictureBox();
            btnAnyadirImg = new Button();
            panel1 = new Panel();
            btnAlta = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbOjo).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(47, 65, 122);
            label1.Location = new Point(2, 120);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 0;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(47, 65, 122);
            label2.Location = new Point(21, 41);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(47, 65, 122);
            label3.Location = new Point(13, 79);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 2;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(47, 65, 122);
            label4.Location = new Point(39, 163);
            label4.Name = "label4";
            label4.Size = new Size(43, 19);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(47, 65, 122);
            label5.Location = new Point(18, 205);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 4;
            label5.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(47, 65, 122);
            label6.Location = new Point(48, 30);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 5;
            label6.Text = "Activo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(47, 65, 122);
            label7.Location = new Point(30, 64);
            label7.Name = "label7";
            label7.Size = new Size(65, 19);
            label7.TabIndex = 6;
            label7.Text = "Manager";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(47, 65, 122);
            label8.Location = new Point(52, 101);
            label8.Name = "label8";
            label8.Size = new Size(43, 19);
            label8.TabIndex = 7;
            label8.Text = "Store";
            // 
            // cbManager
            // 
            cbManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cbManager.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbManager.ForeColor = Color.FromArgb(224, 197, 86);
            cbManager.FormattingEnabled = true;
            cbManager.Location = new Point(141, 62);
            cbManager.Name = "cbManager";
            cbManager.Size = new Size(151, 28);
            cbManager.TabIndex = 8;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(3, 7);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(42, 23);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sí";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(70, 6);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(46, 23);
            radioButton2.TabIndex = 10;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // cbStore
            // 
            cbStore.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStore.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbStore.ForeColor = Color.FromArgb(224, 197, 86);
            cbStore.FormattingEnabled = true;
            cbStore.Location = new Point(141, 99);
            cbStore.Name = "cbStore";
            cbStore.Size = new Size(151, 28);
            cbStore.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbOjo);
            groupBox1.Controls.Add(cbPrefijos);
            groupBox1.Controls.Add(tbTelefono);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(tbApellidos);
            groupBox1.Controls.Add(tbPass);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(224, 197, 86);
            groupBox1.Location = new Point(55, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 245);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // pbOjo
            // 
            pbOjo.Image = Properties.Resources.eye_outline;
            pbOjo.InitialImage = Properties.Resources.eye_outline;
            pbOjo.Location = new Point(230, 117);
            pbOjo.Name = "pbOjo";
            pbOjo.Size = new Size(27, 26);
            pbOjo.SizeMode = PictureBoxSizeMode.Zoom;
            pbOjo.TabIndex = 11;
            pbOjo.TabStop = false;
            pbOjo.Click += pbOjo_Click;
            // 
            // cbPrefijos
            // 
            cbPrefijos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrefijos.ForeColor = Color.FromArgb(224, 197, 86);
            cbPrefijos.FormattingEnabled = true;
            cbPrefijos.Location = new Point(87, 202);
            cbPrefijos.Name = "cbPrefijos";
            cbPrefijos.Size = new Size(63, 27);
            cbPrefijos.TabIndex = 10;
            // 
            // tbTelefono
            // 
            tbTelefono.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbTelefono.ForeColor = Color.FromArgb(47, 65, 122);
            tbTelefono.Location = new Point(156, 203);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(101, 26);
            tbTelefono.TabIndex = 9;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.ForeColor = Color.FromArgb(47, 65, 122);
            tbEmail.Location = new Point(94, 160);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(163, 26);
            tbEmail.TabIndex = 8;
            // 
            // tbApellidos
            // 
            tbApellidos.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbApellidos.ForeColor = Color.FromArgb(47, 65, 122);
            tbApellidos.Location = new Point(94, 76);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(125, 26);
            tbApellidos.TabIndex = 7;
            // 
            // tbPass
            // 
            tbPass.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbPass.ForeColor = Color.FromArgb(47, 65, 122);
            tbPass.Location = new Point(94, 117);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(125, 26);
            tbPass.TabIndex = 5;
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.ForeColor = Color.FromArgb(47, 65, 122);
            tbNombre.Location = new Point(94, 38);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 26);
            tbNombre.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBorrar);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(btnAnyadirImg);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cbStore);
            groupBox2.Controls.Add(cbManager);
            groupBox2.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(224, 197, 86);
            groupBox2.Location = new Point(400, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(337, 299);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Propiedades";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Transparent;
            btnBorrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBorrar.Cursor = Cursors.Hand;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.ForeColor = Color.FromArgb(47, 65, 122);
            btnBorrar.Image = Properties.Resources.image_off_outline_custom;
            btnBorrar.Location = new Point(20, 231);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(99, 35);
            btnBorrar.TabIndex = 16;
            btnBorrar.Text = "Borrar";
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Visible = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(141, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnAnyadirImg
            // 
            btnAnyadirImg.BackColor = Color.Transparent;
            btnAnyadirImg.BackgroundImageLayout = ImageLayout.Zoom;
            btnAnyadirImg.Cursor = Cursors.Hand;
            btnAnyadirImg.FlatStyle = FlatStyle.Flat;
            btnAnyadirImg.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnyadirImg.ForeColor = Color.FromArgb(47, 65, 122);
            btnAnyadirImg.Image = Properties.Resources.image_plus_outline_custom__3_;
            btnAnyadirImg.Location = new Point(20, 190);
            btnAnyadirImg.Name = "btnAnyadirImg";
            btnAnyadirImg.Size = new Size(99, 35);
            btnAnyadirImg.TabIndex = 14;
            btnAnyadirImg.Text = "Imagen";
            btnAnyadirImg.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnyadirImg.UseVisualStyleBackColor = true;
            btnAnyadirImg.Click += btnAnyadirImg_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Location = new Point(141, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(138, 33);
            panel1.TabIndex = 12;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.FromArgb(224, 197, 86);
            btnAlta.Cursor = Cursors.Hand;
            btnAlta.FlatAppearance.BorderSize = 0;
            btnAlta.FlatStyle = FlatStyle.Popup;
            btnAlta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlta.ForeColor = Color.FromArgb(47, 65, 122);
            btnAlta.Image = Properties.Resources.anyadirEmpleado;
            btnAlta.Location = new Point(328, 370);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(156, 44);
            btnAlta.TabIndex = 15;
            btnAlta.Text = "ALTA";
            btnAlta.TextAlign = ContentAlignment.MiddleRight;
            btnAlta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = " ";
            openFileDialog1.Filter = "PNG (*.png)|*.png|JPG(*.jpg)|*.jpg\" ";
            openFileDialog1.InitialDirectory = "MyPictures";
            // 
            // FormAltaEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 451);
            Controls.Add(btnAlta);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MinimumSize = new Size(783, 498);
            Name = "FormAltaEmpleado";
            Text = "Alta empleado";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbOjo).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbManager;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox cbStore;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        public TextBox tbTelefono;
        public TextBox tbEmail;
        public TextBox tbApellidos;
        public TextBox tbNombre;
        public TextBox tbPass;
        private Button btnAlta;
        private OpenFileDialog openFileDialog1;
        private Button btnAnyadirImg;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ComboBox cbPrefijos;
        private PictureBox pbOjo;
        private Button btnBorrar;
    }
}