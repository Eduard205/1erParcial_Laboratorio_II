using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroDrago
{
    public partial class FrmMenuPrincipal : Form
    {
        private List<Vuelo> listaVuelos = new List<Vuelo>();
        private int dni;
        private int edad;
        private string nombre;
        private string apellido;
        private bool esPremium;
        private EEquipaje equipaje;

        public int Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public bool EsPremium { get => esPremium; set => esPremium = value; }
        public EEquipaje Equipaje { get => equipaje; set => equipaje = value; }

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            listaVuelos = DatosNegocio.ListaVuelos;
        }

        public FrmMenuPrincipal(Usuario nombre) : this()
        {
            labNombreOperador.Text= $"Vendedor: {nombre.Nombre}, {DateTime.Now.ToString("dd-MM-yyyy")}";
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin FrmLogin = new FrmLogin();
            FrmLogin.Show();
            this.Hide();        
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            gboxVuelosNacionales.Visible = false;
            gBoxVuelosInternacionales.Visible = false;
            btnCerrar.Visible = false;
            btnAltaVuelo.Visible = false;
            gBoxVenderPasajes.Visible = false;
            gBoxVueloNacional.Visible = false;
            gBoxVueloInternacional.Visible = false;

            cboEquipajeNac.DataSource = Enum.GetValues(typeof(EEquipaje));
            cboEquipajeInt.DataSource = Enum.GetValues(typeof(EEquipaje));
            cboNroVueloInt.DataSource = DatosNegocio.ListarNroVuelosInternacional;
            cboNroVueloNac.DataSource = DatosNegocio.ListarNroVuelosNacional;

            cboEquipajeNac.SelectedItem = null;
            cboEquipajeInt.SelectedItem = null;
            cboNroVueloInt.SelectedItem = null;
            cboNroVueloNac.SelectedItem = null;
        }

        private void dtgVuelosNacionales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgVuelosInternacionales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrarVuelos_Click(object sender, EventArgs e)
        {
            dtgVuelosNacionales.DataSource = null;
            dtgVuelosNacionales.DataSource = DatosNegocio.MostrarVuelosNacional;

            dtgVuelosInternacionales.DataSource = null;
            dtgVuelosInternacionales.DataSource = DatosNegocio.MostrarVuelosInternacional;

            gboxVuelosNacionales.Visible = true;
            gBoxVuelosInternacionales.Visible = true;
            btnCerrar.Visible = true;
            btnAltaVuelo.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            gboxVuelosNacionales.Visible = false;
            gBoxVuelosInternacionales.Visible = false;
            btnCerrar.Visible = false;
            btnAltaVuelo.Visible = false;
        }

        private void btnAltaVuelo_Click(object sender, EventArgs e)
        {
            FrmAltaVuelo frmAltaVuelo = new FrmAltaVuelo();
            DialogResult result = frmAltaVuelo.ShowDialog();

            if (result == DialogResult.OK)
            {
                ActualizarDatos();
            }
            else
            {
                MessageBox.Show("No se actualizo la lista de vuelos");
            }
        }

        private void ActualizarDatos()
        {
            dtgVuelosNacionales.DataSource = null;
            dtgVuelosNacionales.DataSource = DatosNegocio.MostrarVuelosNacional;

            dtgVuelosInternacionales.DataSource = null;
            dtgVuelosInternacionales.DataSource = DatosNegocio.MostrarVuelosInternacional;
        }

        private void btnVenderPasajes_Click(object sender, EventArgs e)
        {
            gBoxVenderPasajes.Visible = true;
        }

        private void chklDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectorDestino = chklDestino.SelectedIndex;

            if (selectorDestino == 0)
            {
                //Es Nacional
                gBoxVueloNacional.Visible = true;
                gBoxVueloInternacional.Visible = false;
            }
            else
            {
                //Es Internacional
                gBoxVueloInternacional.Visible = true;
                gBoxVueloNacional.Visible = false;
            }
        }

        private void btnCargarPasajeroNac_Click(object sender, EventArgs e)
        {
            string patron = "[!\"·$%&/()=¿¡?'_:;,|@#€*+-.123456789]";

            try
            {
                if ((!string.IsNullOrEmpty(txtNombreNac.Text.Trim()) &&
                    (!string.IsNullOrEmpty(txtApellidoNac.Text.Trim())) &&
                    (!string.IsNullOrEmpty(txtEdadNac.Text.Trim())) &&
                    (!string.IsNullOrEmpty(txtDniNac.Text.Trim()))) &&
                    (cboEquipajeNac.SelectedItem is not null) &&
                    (chklClasePremiumNac.SelectedItem is not null) &&
                    (!string.IsNullOrEmpty((string)cboNroVueloNac.SelectedItem)))
                {
                    if (int.TryParse(txtDniNac.Text, out dni) && DatosNegocio.ValidarDni(Dni) && int.TryParse(txtEdadNac.Text, out edad) &&
                        (!Regex.IsMatch(txtNombreNac.Text, @"^[0-9]+$")) &&
                        (!Regex.IsMatch(txtApellidoNac.Text, patron)) &&
                        (Dni > 0 && Edad >= 1))
                    {  
                        Nombre = txtNombreNac.Text;
                        Apellido = txtApellidoNac.Text;
                        Dni = int.Parse(txtDniNac.Text);
                        Edad = int.Parse(txtEdadNac.Text);
                        Equipaje = (EEquipaje)cboEquipajeNac.SelectedItem;

                        if(chklClasePremiumNac.SelectedIndex==0)
                        {
                            EsPremium = true;
                        }
                        else
                        {
                           EsPremium = false;
                        }
                       
                        dtgCargarPasajero.Rows.Add(Nombre, Apellido, Dni, Edad, Equipaje, EsPremium);
                    }
                    else
                    {
                        MessageBox.Show("Ingreso datos invalidos");
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar TODOS los campos");
                }
            }
            catch (Exception)
            {
                throw new Exception("Fallo al agregar al Pasajero");
            }
        }

        private void dtgCargarPasajero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargarPasajeroInt_Click(object sender, EventArgs e)
        {
            string patron = "[!\"·$%&/()=¿¡?'_:;,|@#€*+-.123456789]";

            try
            {
                if ((!string.IsNullOrEmpty(txtNombreInt.Text.Trim()) &&
                    (!string.IsNullOrEmpty(txtApellidoInt.Text.Trim())) &&
                    (!string.IsNullOrEmpty(txtEdadInt.Text.Trim())) &&
                    (!string.IsNullOrEmpty(txtDniInt.Text.Trim()))) &&
                    (cboEquipajeInt.SelectedItem is not null) &&
                    (chklClasePremiumInt.SelectedItem is not null) &&
                    (!string.IsNullOrEmpty((string)cboNroVueloInt.SelectedItem)))
                {
                    if (int.TryParse(txtDniInt.Text, out dni) && DatosNegocio.ValidarDni(Dni) && int.TryParse(txtEdadInt.Text, out edad) &&
                        (!Regex.IsMatch(txtNombreInt.Text, @"^[0-9]+$")) &&
                        (!Regex.IsMatch(txtApellidoInt.Text, patron)) &&
                        (Dni > 0 && Edad >= 1))
                    {
                        Nombre = txtNombreInt.Text;
                        Apellido = txtApellidoInt.Text;
                        Dni = int.Parse(txtDniInt.Text);
                        Edad = int.Parse(txtEdadInt.Text);
                        Equipaje = (EEquipaje)cboEquipajeInt.SelectedItem;
                       
                        if (chklClasePremiumInt.SelectedIndex == 0)
                        {
                            EsPremium = true;
                        }
                        else
                        {
                            EsPremium = false;
                        }

                        dtgCargarPasajero.Rows.Add(Nombre, Apellido, Dni, Edad, Equipaje, EsPremium);
                    }
                    else
                    {
                        MessageBox.Show("Ingreso datos invalidos");
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar TODOS los campos");
                }
            }
            catch (Exception)
            {
                throw new Exception("Fallo al agregar al Pasajero");
            }
        }

        private void gBoxVueloNacional_Enter(object sender, EventArgs e)
        {

        }
    }
}
