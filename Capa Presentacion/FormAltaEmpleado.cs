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
using CapaNegocio;
///<author> Miguel Ángel Moreno García</author>

namespace Capa_Presentacion
{
    public partial class FormAltaEmpleado : Form
    {
        private List<Staff> personal;
        private List<Store> stores;
        public event Action EmpleadoModificado; //Evento utilizado para comunicar al form ModificarEmpleado que se debe actualizar el dataGridView

        //Modo editar
        private bool editar;
        private Staff? empleadoEditar;

        //Alertas de validación
        private ToolTip TTIP = new ToolTip();
        private ErrorProvider errorProvider = new ErrorProvider();

        public FormAltaEmpleado(bool editar = false)
        {
            InitializeComponent();

            //Indicamos si queremos crear un formulario de editar y cambiamos a los estilos de editar
            this.editar = editar;
            if (editar)
            {
                btnAlta.Text = "EDITAR";
                btnAlta.Image = Properties.Resources.editarEmpleado;
                this.Text = "Modificar empleado";
            }

            //Introducimos los objectos Staff dentro del ComboBox y mostramos el nombre de los empleados.
            personal = Ventas.ListarStaff();
            Staff staffNulo = new Staff()//Añado un staff vacio para que se muestre en la lista y podamos elegir que no haya manager
            {
                FirstName = "",
                StaffId = -1
            };

            personal.Insert(0, staffNulo); //Lo añado en la primera posición de la lista
            cbManager.DataSource = personal;
            cbManager.ValueMember = "StaffId";
            cbManager.DisplayMember = "FirstName";
            cbManager.SelectedIndex = 0; //El staffNulo aparecerá seleccionado por defecto
            cbManager.SelectedItem.ToString();


            //Introducimos los objectos Store dentro del ComboBox y mostramos el nombre de las tiendas
            stores = Ventas.ListarStores();
            cbStore.DataSource = stores;
            cbStore.ValueMember = "StoreId";
            cbStore.DisplayMember = "StoreName";
            cbStore.SelectedIndex = 0;
            cbStore.SelectedItem.ToString();


            //Introducimos los prefijos en el ComboBox
            string[] prefijoPaises = new string[]
            {
                "+34", //(España)
                "+49", //(Alemania)
                "+353", //(Irlanda)
                "+57", //(Colombia)
                "+52", //(México)
                "+54", //(Argentina)
                "+1", //(Estados Unidos)
                "+234" //(Nigeria)
            };
            cbPrefijos.Items.AddRange(prefijoPaises);
            cbPrefijos.SelectedIndex = 0;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.Trim();
            string apellidos = tbApellidos.Text.Trim();
            string pass = tbPass.Text.Trim();
            string email = tbEmail.Text.Trim();
            string telefono = tbTelefono.Text.Trim();

            if (ValidarCampos(nombre, apellidos, pass, email, telefono))
            {
                //Obtenemos el array de bytes de la imagen añadida
                Image image = pictureBox1.Image ?? Properties.Resources.SIN_FOTO;
                byte[] bytesImagen = ConvertirImagenAArray(image);

                //Obtenemos el valor de Activo
                byte activo = (byte)(radioButton1.Checked ? 1 : 0);

                //Obtenemos el id de la Store seleccionada
                int idStore = (int)cbStore.SelectedValue;

                //Obtenemos el id del Manager seleccionado
                int? idManager = (int)cbManager.SelectedValue != -1 ? (int)cbManager.SelectedValue : null;

                //Juntamos el prefijo + telefono para introducirlo en la base de datos
                if (tbTelefono.Text != "" && cbPrefijos.SelectedItem != null)
                {
                    telefono = "(" + cbPrefijos.SelectedItem.ToString() + ")" + telefono;
                }
                else
                {
                    telefono = null;
                }

                //Si el formulario no está en modo edición, insertamos el empleado creado
                if (!editar)
                {
                    Staff empleadoInsertar = new Staff(nombre, apellidos, Validaciones.HashPassword(pass), email, telefono, activo, idStore, bytesImagen, idManager);
                    Ventas.InsertarStaff(empleadoInsertar);
                    EmpleadoModificado?.Invoke();
                    MessageBox.Show("¡Empleado dado de alta con éxito!.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Si está en modo edición actualizamos el staff
                else
                {
                    empleadoEditar.FirstName = nombre;
                    empleadoEditar.LastName = apellidos;
                    empleadoEditar.Email = email;
                    empleadoEditar.Active = activo;
                    // Solo cambiamos la contraseña si el campo de la contraseña no está vacío, sino se mantendrá la anterior pass
                    if (!string.IsNullOrEmpty(pass))
                    {
                        empleadoEditar.PasswordStaff = Validaciones.HashPassword(pass);
                    }
                    empleadoEditar.Phone = telefono;
                    empleadoEditar.ManagerId = idManager;
                    empleadoEditar.StoreId = idStore;
                    empleadoEditar.ImageStaff = bytesImagen;
                    Ventas.ActualizarStaff(empleadoEditar);
                    EmpleadoModificado?.Invoke();
                    MessageBox.Show("¡Empleado actualizado con éxito!.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void pbOjo_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '\0')
            {
                tbPass.PasswordChar = '*';
                pbOjo.Image = Properties.Resources.eye_outline;
            }
            else
            {
                tbPass.PasswordChar = '\0';
                pbOjo.Image = Properties.Resources.eye_closed;
            }
        }
        private void btnAnyadirImg_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                //Activo el boton de borrar imagen
                btnBorrar.Visible = true;
            }
        }
        public void AplicarDatosFila(DataGridViewRow fila)
        {
            string staffId = fila.Cells[0].Value.ToString();
            //Instancio el Staff que vamos a editar
            using (Ventas v = new Ventas())
            {
                empleadoEditar = v.ObtenerStaff(Convert.ToInt32(staffId));
            }

            //Relleno los campos del formulario con sus respectivos valores
            tbNombre.Text = empleadoEditar.FirstName;
            tbApellidos.Text = empleadoEditar.LastName;
            tbEmail.Text = empleadoEditar.Email;

            if (empleadoEditar.Phone != null)
            {
                tbTelefono.Text = empleadoEditar.Phone.Split(")")[1].Trim('(', ')'); //Muestro el telefono sin su prefijo
                cbPrefijos.SelectedItem = empleadoEditar.Phone.Split(")")[0].Trim('(', ')'); //Selecciono el prefijo
            }

            if (empleadoEditar.ImageStaff != null)
            {
                pictureBox1.Image = ConvertirArrayAImage(empleadoEditar.ImageStaff);
                btnBorrar.Visible = true;
            }

            //Valor Active
            if (empleadoEditar.Active == 1)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            };
            //Valor Stores
            string nombreStore = fila.Cells["Nombre Tienda"].Value.ToString();
            cbStore.SelectedItem = stores.Where(s => s.StoreName == nombreStore).FirstOrDefault();
            //Valor Manager
            string nombreManager = fila.Cells["Nombre Mánager"].Value.ToString(); ;
            cbManager.SelectedItem = personal.Where(p => p.FirstName == nombreManager).FirstOrDefault();
        }
        private bool ValidarNombre(string nombre, out string cadenaErrores)
        {
            cadenaErrores = "";
            if (nombre.Length == 0)
            {
                cadenaErrores = "El nombre no puede estar vacio" + Environment.NewLine;
                return false;
            }
            else if (nombre.Length > 50)
            {
                cadenaErrores = "Nombre demasiado largo" + Environment.NewLine;
                return false;
            }
            return true;
        }
        private bool ValidarApellidos(string apellidos, out string cadenaErrores)
        {
            cadenaErrores = "";
            if (apellidos.Length == 0)
            {
                cadenaErrores = "Los apellidos no pueden estar vacios" + Environment.NewLine;
                return false;
            }
            else if (apellidos.Length > 50)
            {
                cadenaErrores = "Apellidos demasiado largos" + Environment.NewLine;
                return false;
            }
            return true;
        }
        private bool ValidarPassword(string pass, out string cadenaErrores)
        {
            cadenaErrores = "";
            if (pass.Length == 0)
            {
                cadenaErrores = "La contraseña no puede estar vacia" + Environment.NewLine;
                return false;
            }
            else if (pass.Length > 64)
            {
                cadenaErrores = "Contraseña demasiado larga" + Environment.NewLine;
                return false;
            }
            return true;
        }
        private bool ValidarEmail(string email, Ventas ventas, out string cadenaErrores)
        {
            cadenaErrores = "";
            if (email.Length == 0)
            {
                cadenaErrores = "El email no puede estar vacio" + Environment.NewLine;
                return false;
            }
            else if (email.Length > 255)
            {
                cadenaErrores = "Email demasiado largo" + Environment.NewLine;
                return false;
            }
            else if (!Validaciones.ValidarFormatoEmail(email))
            {
                cadenaErrores = "Formato del email incorrecto";
                return false;
            }
            else if (ventas.VerificarEmail(email))
            {
                if ((editar && email != empleadoEditar.Email) || !editar)
                {
                    cadenaErrores = "El email introducido ya existe en la base de datos" + Environment.NewLine;
                    return false;
                }
            }
            return true;
        }
        private bool ValidarTelefono(string telefono, out string cadenaErrores)
        {
            cadenaErrores = "";
            if (telefono.Length > 0)
            {
                if (!Validaciones.ValidarFormatoTelefono(telefono))
                {
                    cadenaErrores = "Formato de telefono no válido" + Environment.NewLine;
                    return false;
                }
            }
            return true;
        }
        private bool ValidarCampos(string nombre, string apellidos, string pass, string email, string telefono)
        {
            bool valNombre, valApellidos, valPass, valEmail, valTelefono;
            string cadenaErrores = "";
            Ventas ventas = new Ventas();

            //Validación nombre
            if (!ValidarNombre(nombre, out cadenaErrores))
            {
                MostrarError(tbNombre, cadenaErrores);
                valNombre = false;
            }
            else
            {
                LimpiarError(tbNombre);
                valNombre = true;
            }

            //Validación apellidos
            if (!ValidarApellidos(apellidos, out cadenaErrores))
            {
                MostrarError(tbApellidos, cadenaErrores);
                valApellidos = false;
            }
            else
            {
                LimpiarError(tbApellidos);
                valApellidos = true;
            }

            //Validación password
            if (!ValidarPassword(pass, out cadenaErrores) && !editar) //En el modo edición se puede dejar la contraseña vacía si no se quiere modificar
            {
                MostrarError(tbPass, cadenaErrores);
                valPass = false;
            }
            else
            {
                LimpiarError(tbPass);
                valPass = true;
            }

            //Validación email
            if (!ValidarEmail(email, ventas, out cadenaErrores))
            {
                MostrarError(tbEmail, cadenaErrores);
                valEmail = false;
            }
            else
            {
                LimpiarError(tbEmail);
                valEmail = true;
            }

            //Validación telefono
            if (!ValidarTelefono(telefono, out cadenaErrores))
            {
                MostrarError(tbTelefono, cadenaErrores);
                valTelefono = false;
            }
            else
            {
                LimpiarError(tbTelefono);
                valTelefono = true;
            }

            if (!valNombre || !valApellidos || !valPass || !valEmail || !valTelefono)
            {
                return false;
            }

            return true;
        }
        private void MostrarError(Control control, string mensaje)
        {
            control.BackColor = Color.LightCoral;
            TTIP.SetToolTip(control, mensaje);
            errorProvider.SetError(control, mensaje);
        }
        private void LimpiarError(Control control)
        {
            control.BackColor = Color.GreenYellow;
            TTIP.SetToolTip(control, "");
            errorProvider.SetError(control, "");
        }
        private byte[] ConvertirImagenAArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private Image ConvertirArrayAImage(byte[] array)
        {
            using (var ms = new MemoryStream(array))
            {
                return Image.FromStream(ms);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

            //Desactivo el boton de borrar imagen
            btnBorrar.Visible = false;
        }
    }
}
