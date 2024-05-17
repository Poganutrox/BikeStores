namespace Capa_Presentacion
{
    partial class FormPrincipal
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
            staffToolStripMenuItem = new ToolStripMenuItem();
            altaEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            modificarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            bajaProductoToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            altaDeProductosToolStripMenuItem = new ToolStripMenuItem();
            modificarProductoToolStripMenuItem = new ToolStripMenuItem();
            bajaDeProductoToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            nuevaToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            none = new ToolStripMenuItem();
            totalPedidosPorClienteToolStripMenuItem = new ToolStripMenuItem();
            productosPorCategoríaToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            nombreStaff = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            imageStaff = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageStaff).BeginInit();
            SuspendLayout();
            // 
            // staffToolStripMenuItem
            // 
            staffToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaEmpleadoToolStripMenuItem, modificarEmpleadoToolStripMenuItem, bajaProductoToolStripMenuItem });
            staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            staffToolStripMenuItem.Size = new Size(54, 24);
            staffToolStripMenuItem.Text = "Staff";
            // 
            // altaEmpleadoToolStripMenuItem
            // 
            altaEmpleadoToolStripMenuItem.Name = "altaEmpleadoToolStripMenuItem";
            altaEmpleadoToolStripMenuItem.Size = new Size(228, 26);
            altaEmpleadoToolStripMenuItem.Text = "Alta empleado";
            altaEmpleadoToolStripMenuItem.Click += altaEmpleadoToolStripMenuItem_Click;
            // 
            // modificarEmpleadoToolStripMenuItem
            // 
            modificarEmpleadoToolStripMenuItem.Name = "modificarEmpleadoToolStripMenuItem";
            modificarEmpleadoToolStripMenuItem.Size = new Size(228, 26);
            modificarEmpleadoToolStripMenuItem.Text = "Modificar empleado";
            modificarEmpleadoToolStripMenuItem.Click += modificarEmpleadoToolStripMenuItem_Click;
            // 
            // bajaProductoToolStripMenuItem
            // 
            bajaProductoToolStripMenuItem.Name = "bajaProductoToolStripMenuItem";
            bajaProductoToolStripMenuItem.Size = new Size(228, 26);
            bajaProductoToolStripMenuItem.Text = "Baja producto";
            bajaProductoToolStripMenuItem.Click += bajaProductoToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaDeProductosToolStripMenuItem, modificarProductoToolStripMenuItem, bajaDeProductoToolStripMenuItem });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(89, 24);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // altaDeProductosToolStripMenuItem
            // 
            altaDeProductosToolStripMenuItem.Name = "altaDeProductosToolStripMenuItem";
            altaDeProductosToolStripMenuItem.Size = new Size(220, 26);
            altaDeProductosToolStripMenuItem.Text = "Alta de productos";
            // 
            // modificarProductoToolStripMenuItem
            // 
            modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            modificarProductoToolStripMenuItem.Size = new Size(220, 26);
            modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            // 
            // bajaDeProductoToolStripMenuItem
            // 
            bajaDeProductoToolStripMenuItem.Name = "bajaDeProductoToolStripMenuItem";
            bajaDeProductoToolStripMenuItem.Size = new Size(220, 26);
            bajaDeProductoToolStripMenuItem.Text = "Baja de producto";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaToolStripMenuItem, modificarToolStripMenuItem });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(75, 24);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // nuevaToolStripMenuItem
            // 
            nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            nuevaToolStripMenuItem.Size = new Size(156, 26);
            nuevaToolStripMenuItem.Text = "Nueva";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(156, 26);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // none
            // 
            none.DropDownItems.AddRange(new ToolStripItem[] { totalPedidosPorClienteToolStripMenuItem, productosPorCategoríaToolStripMenuItem });
            none.Name = "none";
            none.Size = new Size(93, 24);
            none.Text = "Estadíticas";
            // 
            // totalPedidosPorClienteToolStripMenuItem
            // 
            totalPedidosPorClienteToolStripMenuItem.Name = "totalPedidosPorClienteToolStripMenuItem";
            totalPedidosPorClienteToolStripMenuItem.Size = new Size(256, 26);
            totalPedidosPorClienteToolStripMenuItem.Text = "Total Pedidos por cliente";
            // 
            // productosPorCategoríaToolStripMenuItem
            // 
            productosPorCategoríaToolStripMenuItem.Name = "productosPorCategoríaToolStripMenuItem";
            productosPorCategoríaToolStripMenuItem.Size = new Size(256, 26);
            productosPorCategoríaToolStripMenuItem.Text = "Productos por categoría";
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturaToolStripMenuItem });
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(81, 24);
            informesToolStripMenuItem.Text = "Informes";
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(224, 26);
            facturaToolStripMenuItem.Text = "Factura";
            facturaToolStripMenuItem.Click += facturaToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(98, 24);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { staffToolStripMenuItem, productosToolStripMenuItem, pedidosToolStripMenuItem, none, informesToolStripMenuItem, acercaDeToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = none;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1445, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1445, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.briefcase_plus_outline;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(126, 24);
            toolStripButton1.Text = "Nuevo Pedido";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.store_search_outline;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(150, 24);
            toolStripButton2.Text = "Buscar Productos ";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = Properties.Resources.printer_outline;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(172, 24);
            toolStripButton3.Text = " Imprimir una factura";
            // 
            // nombreStaff
            // 
            nombreStaff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nombreStaff.AutoSize = true;
            nombreStaff.BackColor = Color.Transparent;
            nombreStaff.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nombreStaff.ForeColor = Color.FromArgb(47, 65, 122);
            nombreStaff.Location = new Point(3, 154);
            nombreStaff.Name = "nombreStaff";
            nombreStaff.Size = new Size(216, 23);
            nombreStaff.TabIndex = 1;
            nombreStaff.Text = "label1";
            nombreStaff.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(imageStaff, 0, 0);
            tableLayoutPanel1.Controls.Add(nombreStaff, 0, 2);
            tableLayoutPanel1.Location = new Point(1211, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(222, 177);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // imageStaff
            // 
            imageStaff.BackColor = Color.Transparent;
            imageStaff.Dock = DockStyle.Top;
            imageStaff.Location = new Point(3, 4);
            imageStaff.Margin = new Padding(3, 4, 3, 4);
            imageStaff.Name = "imageStaff";
            imageStaff.Size = new Size(216, 138);
            imageStaff.SizeMode = PictureBoxSizeMode.Zoom;
            imageStaff.TabIndex = 2;
            imageStaff.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 1055);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            FormClosing += salirFormulario_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem staffToolStripMenuItem;
        private ToolStripMenuItem altaEmpleadoToolStripMenuItem;
        private ToolStripMenuItem modificarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem bajaProductoToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem altaDeProductosToolStripMenuItem;
        private ToolStripMenuItem modificarProductoToolStripMenuItem;
        private ToolStripMenuItem bajaDeProductoToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem nuevaToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem none;
        private ToolStripMenuItem totalPedidosPorClienteToolStripMenuItem;
        private ToolStripMenuItem productosPorCategoríaToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        public Label nombreStaff;
        private TableLayoutPanel tableLayoutPanel1;
        public PictureBox imageStaff;
    }
}