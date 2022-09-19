using Biblioteca;

namespace AeroDrago
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña");
            }
            else
            {
                if (int.TryParse(txtUsuario.Text, out int id))
                {
                    Usuario usuarioLogueado = DatosNegocio.LoguearUsuario(id, txtContrasena.Text);

                    if (usuarioLogueado is not null)
                    {
                        MessageBox.Show($"Bienvenido a Aero Drago {usuarioLogueado.Nombre}");
                        FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal();
                        menuPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario o contraseña es incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Ingreso datos invalidos");
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
        }

    }
}