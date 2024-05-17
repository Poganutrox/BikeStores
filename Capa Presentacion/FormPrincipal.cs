using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///<author> Miguel Ángel Moreno García</author>

namespace Capa_Presentacion
{
    public partial class FormPrincipal : Form
    {
        Staff staffRegistrado;
        public FormPrincipal(Staff staff = null)
        {
            InitializeComponent();
            if(staff != null)
            {
                staffRegistrado = staff;
                nombreStaff.Text = staffRegistrado.FirstName + " " + staffRegistrado.LastName;
                Image? image = staffRegistrado.ImageStaff == null
                    ? Properties.Resources.SIN_FOTO
                    : (Bitmap?)((new ImageConverter()).ConvertFrom(staffRegistrado.ImageStaff));
                imageStaff.Image = image;
            }
            
        }

        private void salirFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void altaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaEmpleado f = new FormAltaEmpleado();
            f.MdiParent = this;
            f.Show();
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarEmpleado f = new FormModificarEmpleado();
            f.MdiParent = this;
            f.Show();
        }

        private void bajaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarEmpleado f = new FormModificarEmpleado(true);
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormAltaPedido formAltaProducto = new FormAltaPedido(staffRegistrado);
            formAltaProducto.MdiParent = this;
            formAltaProducto.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormBuscador f = new FormBuscador("producto");
            f.ShowDialog();

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscador formBuscador = new FormBuscador("factura");
            formBuscador.MdiParent = this;
            formBuscador.Show();
        }
    }
}
