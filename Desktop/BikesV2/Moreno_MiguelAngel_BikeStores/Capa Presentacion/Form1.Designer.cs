using System.Windows.Forms;

namespace Capa_Presentacion
{

    ///<author> Miguel Ángel Moreno García</author>
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
            btnListarPedidos = new Button();
            dataGridView1 = new DataGridView();
            btnBuscarPedido = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            textBox3 = new TextBox();
            btnListarCliente = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            btnListarEmpleado = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel2 = new Panel();
            tbShippingDate = new TextBox();
            tbRequieredDate = new TextBox();
            tbOrderDate = new TextBox();
            tbCostumerID = new TextBox();
            label12 = new Label();
            label11 = new Label();
            btnBorrar = new Button();
            btnActualizar = new Button();
            btnAnyadir = new Button();
            tbOderID = new TextBox();
            label10 = new Label();
            tbStaffID = new TextBox();
            tbStoreID = new TextBox();
            tbOrderStatus = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnListarPedidos
            // 
            btnListarPedidos.Location = new Point(30, 72);
            btnListarPedidos.Name = "btnListarPedidos";
            btnListarPedidos.Size = new Size(118, 29);
            btnListarPedidos.TabIndex = 1;
            btnListarPedidos.Text = "Listar Pedidos";
            btnListarPedidos.UseVisualStyleBackColor = true;
            btnListarPedidos.Click += btnListarPedidos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(856, 505);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnBuscarPedido
            // 
            btnBuscarPedido.Location = new Point(216, 118);
            btnBuscarPedido.Name = "btnBuscarPedido";
            btnBuscarPedido.Size = new Size(94, 29);
            btnBuscarPedido.TabIndex = 3;
            btnBuscarPedido.Text = "Buscar";
            btnBuscarPedido.UseVisualStyleBackColor = true;
            btnBuscarPedido.Click += btnBuscarPedido_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 27);
            textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(btnListarCliente);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnListarEmpleado);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnBuscarPedido);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnListarPedidos);
            panel1.Location = new Point(234, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 168);
            panel1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(501, 72);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 27);
            textBox3.TabIndex = 10;
            // 
            // btnListarCliente
            // 
            btnListarCliente.Location = new Point(493, 118);
            btnListarCliente.Name = "btnListarCliente";
            btnListarCliente.Size = new Size(94, 29);
            btnListarCliente.TabIndex = 9;
            btnListarCliente.Text = "Listar";
            btnListarCliente.UseVisualStyleBackColor = true;
            btnListarCliente.Click += btnListarCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(486, 28);
            label4.Name = "label4";
            label4.Size = new Size(105, 28);
            label4.TabIndex = 8;
            label4.Text = "ID Cliente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(358, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 27);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(334, 28);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 6;
            label3.Text = "ID Empleado";
            // 
            // btnListarEmpleado
            // 
            btnListarEmpleado.Location = new Point(350, 118);
            btnListarEmpleado.Name = "btnListarEmpleado";
            btnListarEmpleado.Size = new Size(94, 29);
            btnListarEmpleado.TabIndex = 5;
            btnListarEmpleado.Text = "Listar";
            btnListarEmpleado.UseVisualStyleBackColor = true;
            btnListarEmpleado.Click += btnListarEmpleado_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(206, 28);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 4;
            label2.Text = "ID Pedido";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(196, 36);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 8;
            label5.Text = "CRUD ORDER";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(tbShippingDate);
            panel2.Controls.Add(tbRequieredDate);
            panel2.Controls.Add(tbOrderDate);
            panel2.Controls.Add(tbCostumerID);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnBorrar);
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(btnAnyadir);
            panel2.Controls.Add(tbOderID);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(tbStaffID);
            panel2.Controls.Add(tbStoreID);
            panel2.Controls.Add(tbOrderStatus);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(956, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 473);
            panel2.TabIndex = 9;
            // 
            // tbShippingDate
            // 
            tbShippingDate.Location = new Point(211, 316);
            tbShippingDate.Name = "tbShippingDate";
            tbShippingDate.Size = new Size(79, 27);
            tbShippingDate.TabIndex = 31;
            // 
            // tbRequieredDate
            // 
            tbRequieredDate.Location = new Point(211, 268);
            tbRequieredDate.Name = "tbRequieredDate";
            tbRequieredDate.Size = new Size(79, 27);
            tbRequieredDate.TabIndex = 30;
            // 
            // tbOrderDate
            // 
            tbOrderDate.Location = new Point(211, 222);
            tbOrderDate.Name = "tbOrderDate";
            tbOrderDate.Size = new Size(79, 27);
            tbOrderDate.TabIndex = 29;
            // 
            // tbCostumerID
            // 
            tbCostumerID.Location = new Point(211, 128);
            tbCostumerID.Name = "tbCostumerID";
            tbCostumerID.Size = new Size(79, 27);
            tbCostumerID.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(95, 135);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 27;
            label12.Text = "Costumer ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(84, 323);
            label11.Name = "label11";
            label11.Size = new Size(102, 20);
            label11.TabIndex = 22;
            label11.Text = "Shipping date";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(385, 326);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 21;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(385, 241);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAnyadir
            // 
            btnAnyadir.Location = new Point(385, 157);
            btnAnyadir.Name = "btnAnyadir";
            btnAnyadir.Size = new Size(94, 29);
            btnAnyadir.TabIndex = 11;
            btnAnyadir.Text = "Añadir";
            btnAnyadir.UseVisualStyleBackColor = true;
            btnAnyadir.Click += btnAnyadir_Click;
            // 
            // tbOderID
            // 
            tbOderID.Location = new Point(211, 88);
            tbOderID.Name = "tbOderID";
            tbOderID.Size = new Size(79, 27);
            tbOderID.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(114, 95);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 18;
            label10.Text = "Order ID";
            // 
            // tbStaffID
            // 
            tbStaffID.Location = new Point(211, 405);
            tbStaffID.Name = "tbStaffID";
            tbStaffID.Size = new Size(79, 27);
            tbStaffID.TabIndex = 17;
            // 
            // tbStoreID
            // 
            tbStoreID.Location = new Point(211, 360);
            tbStoreID.Name = "tbStoreID";
            tbStoreID.Size = new Size(79, 27);
            tbStoreID.TabIndex = 16;
            // 
            // tbOrderStatus
            // 
            tbOrderStatus.Location = new Point(211, 168);
            tbOrderStatus.Name = "tbOrderStatus";
            tbOrderStatus.Size = new Size(79, 27);
            tbOrderStatus.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(121, 412);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 13;
            label9.Text = "Staff ID*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(117, 367);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 12;
            label8.Text = "Store ID*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 271);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 11;
            label7.Text = "Required date*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 225);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 10;
            label6.Text = "Order date*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 175);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 9;
            label1.Text = "Order status*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1555, 730);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "BikeStores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnListarPedidos;
        private DataGridView dataGridView1;
        private Button btnBuscarPedido;
        private TextBox textBox1;
        private Panel panel1;
        private Label label2;
        private Button btnListarEmpleado;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button btnListarCliente;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel2;
        private Label label1;
        private Label label6;
        private TextBox tbStaffID;
        private TextBox tbStoreID;
        private TextBox tbOrderStatus;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnBorrar;
        private Button btnActualizar;
        private Button btnAnyadir;
        private TextBox tbOderID;
        private Label label10;
        private Label label11;
        private TextBox tbCostumerID;
        private Label label12;
        private TextBox tbShippingDate;
        private TextBox tbRequieredDate;
        private TextBox tbOrderDate;
    }
}