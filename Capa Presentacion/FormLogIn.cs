using CapaEntidades;
using CapaNegocio;
using System.Text.RegularExpressions;

namespace Capa_Presentacion
{
    public partial class FormLogIn : Form
    {
        private bool valEmail;
        private bool valPass;
        private ToolTip TTIP = new ToolTip();
        private ErrorProvider errorProvider = new ErrorProvider();

        public FormLogIn()
        {
            InitializeComponent();
            valEmail = false;
            valPass = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string pass = tbPass.Text.Trim();
            string cadenaErrores = "";
            Ventas ventas = new Ventas();

            //Validación email
            if (email.Length == 0)
            {
                cadenaErrores = "El email no puede estar vacio" + Environment.NewLine;
                valEmail = false;
            }
            else if (email.Length > 255)
            {
                cadenaErrores = "Email demasiado largo" + Environment.NewLine;
                valEmail = false;
            }
            else if (!Validaciones.ValidarFormatoEmail(email))
            {
                cadenaErrores = "Formato del email incorrecto" + Environment.NewLine;
                valEmail = false;
            }
            else
            {
                valEmail = true;
            }

            if (!valEmail)
            {
                tbEmail.BackColor = Color.LightCoral;
                TTIP.SetToolTip(tbEmail, cadenaErrores);
                errorProvider.SetError(tbEmail, cadenaErrores);
                valEmail = false;
            }
            else
            {
                tbEmail.BackColor = Color.LightGreen;
                TTIP.SetToolTip(tbEmail, "");
                errorProvider.SetError(tbEmail, "");
                pbDoubleCheck.Visible = true;
            }

            //Validación password
            if (pass.Length == 0)
            {
                cadenaErrores = "La contraseña no puede estar vacia" + Environment.NewLine;
                valPass = false;
            }
            else if (pass.Length > 64)
            {
                cadenaErrores = "Contraseña demasiado larga" + Environment.NewLine;
                valPass = false;
            }
            else
            {
                valPass = true;
            }

            if (!valPass)
            {
                tbPass.BackColor = Color.LightCoral;
                TTIP.SetToolTip(tbPass, cadenaErrores);
                errorProvider.SetError(tbPass, cadenaErrores);
            }
            else
            {
                tbPass.BackColor = Color.LightGreen;
                TTIP.SetToolTip(tbPass, "");
                errorProvider.SetError(tbPass, "");
            }

            //Si las validaciones son exitosas
            if (valEmail && valPass)
            {
                Staff staffRegistrado = Ventas.ObtenerEmpleadoRegistrado(email, pass);

                if (staffRegistrado == null)
                {
                    tbPass.Text = "";
                    tbEmail.BackColor = this.BackColor;
                    MessageBox.Show("Email y contraseña no coinciden.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FormPrincipal fp = new FormPrincipal(staffRegistrado);
                    this.Hide();
                    fp.Show();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbEmail.Text = "";
            tbPass.Text = "";
        }
    }
}
