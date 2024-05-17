using CapaEntidades;
using CapaNegocio;
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
    public partial class FormModificarEmpleado : Form
    {
        bool baja;
        DataTable? empleadosActivos;
        public FormModificarEmpleado(bool baja = false)
        {
            InitializeComponent();

            //Cargamos los datos de los empleados activos en el dataGrid al crearse el formulario de ModificarEmpleado
            empleadosActivos = Ventas.EmpleadosActivos();
            dataGridView1.DataSource = empleadosActivos;
            dataGridView1.Columns["ID"].Visible = false; //Oculto la columna de ID al usuario

            //Modo del formulario, por defecto está en modo no edición
            this.baja = baja;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView filtrado = new DataView(empleadosActivos);
            string busqueda = textBox1.Text;
            filtrado.RowFilter = $"Nombre LIKE '%{busqueda}%' OR Apellidos LIKE '%{busqueda}%' OR Email LIKE '%{busqueda}%'";
            dataGridView1.DataSource = filtrado;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (baja) //Si el formulario está en modo dar de baja, se pregunta al usuario si está seguro que quiere desactivar al empleado
            {
                Staff empleadoBaja;
                int idEmpleado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                using (var v = new Ventas())
                {
                    empleadoBaja = v.ObtenerStaff(idEmpleado);
                }
                string mensaje = $"¿Seguro que quieres dar de baja a {empleadoBaja.FirstName} {empleadoBaja.LastName}?";
                DialogResult respuesta = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    empleadoBaja.Active = 0;
                    Ventas.ActualizarStaff(empleadoBaja);

                    // Refrescamos la tabla
                    empleadosActivos = Ventas.EmpleadosActivos();
                    dataGridView1.DataSource = empleadosActivos;
                   
                }
            }
            else //Si el formulario no está en modo de baja se obtienen los valores de la fila seleccionada y se transfieren al formulariod de AltaEmpleado
            {
                //Obtengo los valores de la fila seleccionada
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                FormAltaEmpleado f = new FormAltaEmpleado(true);
                f.EmpleadoModificado += () => //Me suscribo al evento del formulario AltaEmpleado, por lo que cada vez que este se invoque
                //se actualizará la tabla de este formulario. El evento se activará al editar un empleado o al darlo de alta.
                {
                    // Refrescamos la tabla
                    empleadosActivos = Ventas.EmpleadosActivos();
                    dataGridView1.DataSource = empleadosActivos;
                };
                f.AplicarDatosFila(fila); //Se aplican los datos de la fila seleccionada en el formulario AltaEmpleado
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }
    }
}
