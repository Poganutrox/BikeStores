namespace Capa_Presentacion
{
    partial class FormAltaPedido
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
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            cbEstado = new ComboBox();
            tbEmpleado = new TextBox();
            cbTienda = new ComboBox();
            dtEnvioPedido = new DateTimePicker();
            dtPreparacionPedido = new DateTimePicker();
            dtCreacionPedido = new DateTimePicker();
            btnBuscarCliente = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbTelefono = new TextBox();
            tbEmail = new TextBox();
            tbApellidos = new TextBox();
            tbNombre = new TextBox();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            panel2 = new Panel();
            tbPrecioTotal = new TextBox();
            tbIVA = new TextBox();
            tbPrecioSinIVA = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            btnBuscarProductos = new Button();
            dataGridProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            btnEliminarProducto = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(cbEstado);
            groupBox1.Controls.Add(tbEmpleado);
            groupBox1.Controls.Add(cbTienda);
            groupBox1.Controls.Add(dtEnvioPedido);
            groupBox1.Controls.Add(dtPreparacionPedido);
            groupBox1.Controls.Add(dtCreacionPedido);
            groupBox1.Controls.Add(btnBuscarCliente);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 270);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Pedido";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(381, 169);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(100, 24);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "No indicar";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(247, 63);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(128, 28);
            cbEstado.TabIndex = 15;
            // 
            // tbEmpleado
            // 
            tbEmpleado.BorderStyle = BorderStyle.None;
            tbEmpleado.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmpleado.ForeColor = Color.FromArgb(47, 65, 122);
            tbEmpleado.Location = new Point(250, 234);
            tbEmpleado.Name = "tbEmpleado";
            tbEmpleado.ReadOnly = true;
            tbEmpleado.Size = new Size(125, 19);
            tbEmpleado.TabIndex = 14;
            // 
            // cbTienda
            // 
            cbTienda.FormattingEnabled = true;
            cbTienda.Location = new Point(247, 201);
            cbTienda.Name = "cbTienda";
            cbTienda.Size = new Size(128, 28);
            cbTienda.TabIndex = 13;
            cbTienda.SelectedIndexChanged += cbTienda_SelectedIndexChanged;
            // 
            // dtEnvioPedido
            // 
            dtEnvioPedido.Format = DateTimePickerFormat.Short;
            dtEnvioPedido.Location = new Point(247, 168);
            dtEnvioPedido.Name = "dtEnvioPedido";
            dtEnvioPedido.Size = new Size(128, 27);
            dtEnvioPedido.TabIndex = 12;
            dtEnvioPedido.Value = new DateTime(2023, 11, 22, 16, 10, 45, 0);
            // 
            // dtPreparacionPedido
            // 
            dtPreparacionPedido.Format = DateTimePickerFormat.Short;
            dtPreparacionPedido.Location = new Point(247, 132);
            dtPreparacionPedido.Name = "dtPreparacionPedido";
            dtPreparacionPedido.Size = new Size(128, 27);
            dtPreparacionPedido.TabIndex = 11;
            dtPreparacionPedido.Value = new DateTime(2023, 11, 22, 16, 10, 45, 0);
            // 
            // dtCreacionPedido
            // 
            dtCreacionPedido.Format = DateTimePickerFormat.Short;
            dtCreacionPedido.Location = new Point(247, 97);
            dtCreacionPedido.Name = "dtCreacionPedido";
            dtCreacionPedido.Size = new Size(128, 27);
            dtCreacionPedido.TabIndex = 10;
            dtCreacionPedido.Value = new DateTime(2023, 11, 22, 16, 10, 45, 0);
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Image = Properties.Resources.account_plus_custom;
            btnBuscarCliente.Location = new Point(82, 28);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(98, 30);
            btnBuscarCliente.TabIndex = 7;
            btnBuscarCliente.Text = "Añadir";
            btnBuscarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 237);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 6;
            label7.Text = "Empleado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 204);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 5;
            label6.Text = "Tienda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 173);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha Envio Pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 137);
            label4.Name = "label4";
            label4.Size = new Size(180, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha Preparación Pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 102);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha Creación Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 67);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // tbTelefono
            // 
            tbTelefono.BorderStyle = BorderStyle.None;
            tbTelefono.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbTelefono.ForeColor = Color.FromArgb(47, 65, 122);
            tbTelefono.Location = new Point(119, 135);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.ReadOnly = true;
            tbTelefono.Size = new Size(125, 19);
            tbTelefono.TabIndex = 11;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.ForeColor = Color.FromArgb(47, 65, 122);
            tbEmail.Location = new Point(119, 102);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(207, 19);
            tbEmail.TabIndex = 10;
            // 
            // tbApellidos
            // 
            tbApellidos.BorderStyle = BorderStyle.None;
            tbApellidos.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbApellidos.ForeColor = Color.FromArgb(47, 65, 122);
            tbApellidos.Location = new Point(119, 68);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.ReadOnly = true;
            tbApellidos.Size = new Size(125, 19);
            tbApellidos.TabIndex = 9;
            // 
            // tbNombre
            // 
            tbNombre.BorderStyle = BorderStyle.None;
            tbNombre.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.ForeColor = Color.FromArgb(47, 65, 122);
            tbNombre.Location = new Point(119, 35);
            tbNombre.Name = "tbNombre";
            tbNombre.ReadOnly = true;
            tbNombre.Size = new Size(125, 19);
            tbNombre.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbTelefono);
            groupBox2.Controls.Add(tbNombre);
            groupBox2.Controls.Add(tbEmail);
            groupBox2.Controls.Add(tbApellidos);
            groupBox2.Location = new Point(544, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 179);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Cliente";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 135);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 15;
            label11.Text = "Teléfono";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(56, 102);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 14;
            label10.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 71);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 13;
            label9.Text = "Apellidos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 35);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 12;
            label8.Text = "Nombre";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(panel2);
            groupBox3.Controls.Add(tbPrecioTotal);
            groupBox3.Controls.Add(tbIVA);
            groupBox3.Controls.Add(tbPrecioSinIVA);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(btnBuscarProductos);
            groupBox3.Controls.Add(dataGridProductos);
            groupBox3.Location = new Point(22, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1031, 276);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Productos";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.OliveDrab;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.truck_delivery_outline_custom;
            button1.Location = new Point(809, 211);
            button1.Name = "button1";
            button1.Size = new Size(216, 44);
            button1.TabIndex = 17;
            button1.Text = "Finalizar Pedido";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(805, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 1);
            panel2.TabIndex = 15;
            // 
            // tbPrecioTotal
            // 
            tbPrecioTotal.Location = new Point(913, 172);
            tbPrecioTotal.Name = "tbPrecioTotal";
            tbPrecioTotal.ReadOnly = true;
            tbPrecioTotal.Size = new Size(112, 27);
            tbPrecioTotal.TabIndex = 14;
            // 
            // tbIVA
            // 
            tbIVA.Location = new Point(913, 117);
            tbIVA.Name = "tbIVA";
            tbIVA.ReadOnly = true;
            tbIVA.Size = new Size(112, 27);
            tbIVA.TabIndex = 13;
            tbIVA.Text = "21%";
            // 
            // tbPrecioSinIVA
            // 
            tbPrecioSinIVA.Location = new Point(913, 84);
            tbPrecioSinIVA.Name = "tbPrecioSinIVA";
            tbPrecioSinIVA.ReadOnly = true;
            tbPrecioSinIVA.Size = new Size(112, 27);
            tbPrecioSinIVA.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(787, 175);
            label14.Name = "label14";
            label14.Size = new Size(111, 20);
            label14.TabIndex = 11;
            label14.Text = "Precio total IVA";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(867, 121);
            label13.Name = "label13";
            label13.Size = new Size(31, 20);
            label13.TabIndex = 10;
            label13.Text = "IVA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(813, 87);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 9;
            label12.Text = "Precio total";
            // 
            // btnBuscarProductos
            // 
            btnBuscarProductos.Cursor = Cursors.Hand;
            btnBuscarProductos.Image = Properties.Resources.cart_arrow_down_custom;
            btnBuscarProductos.Location = new Point(809, 28);
            btnBuscarProductos.Name = "btnBuscarProductos";
            btnBuscarProductos.Size = new Size(87, 39);
            btnBuscarProductos.TabIndex = 8;
            btnBuscarProductos.Text = "Añadir";
            btnBuscarProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarProductos.UseVisualStyleBackColor = true;
            btnBuscarProductos.Click += btnBuscarProductos_Click;
            // 
            // dataGridProductos
            // 
            dataGridProductos.AllowUserToAddRows = false;
            dataGridProductos.AllowUserToDeleteRows = false;
            dataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Cantidad, Nombre, Precio, Descuento, btnEliminarProducto });
            dataGridProductos.Location = new Point(6, 26);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.RowHeadersWidth = 51;
            dataGridProductos.RowTemplate.Height = 29;
            dataGridProductos.Size = new Size(777, 229);
            dataGridProductos.TabIndex = 0;
            dataGridProductos.CellBeginEdit += dataGridProductos_CellBeginEdit;
            dataGridProductos.CellClick += dataGridProductos_CellClick;
            dataGridProductos.CellEndEdit += dataGridProductos_CellEndEdit;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 53;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 98;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 79;
            // 
            // Descuento
            // 
            Descuento.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Descuento.HeaderText = "Descuento";
            Descuento.MinimumWidth = 6;
            Descuento.Name = "Descuento";
            Descuento.Width = 108;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            btnEliminarProducto.HeaderText = "";
            btnEliminarProducto.Image = Properties.Resources.cart_arrow_up_custom;
            btnEliminarProducto.MinimumWidth = 6;
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Resizable = DataGridViewTriState.True;
            btnEliminarProducto.Width = 6;
            // 
            // FormAltaPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 683);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormAltaPedido";
            Text = "FormAltaProducto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnBuscarCliente;
        public TextBox tbTelefono;
        public TextBox tbEmail;
        public TextBox tbApellidos;
        public TextBox tbNombre;
        private GroupBox groupBox2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private DateTimePicker dtEnvioPedido;
        private DateTimePicker dtPreparacionPedido;
        private DateTimePicker dtCreacionPedido;
        private TextBox tbEmpleado;
        public ComboBox cbTienda;
        private GroupBox groupBox3;
        private Button btnBuscarProductos;
        private DataGridView dataGridProductos;
        private Label label13;
        private Label label12;
        private TextBox tbPrecioTotal;
        private TextBox tbIVA;
        private TextBox tbPrecioSinIVA;
        private Label label14;
        private Panel panel2;
        private Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewImageColumn btnEliminarProducto;
        private ComboBox cbEstado;
        private CheckBox checkBox2;
    }
}