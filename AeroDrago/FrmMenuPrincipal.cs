using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroDrago
{
    public partial class FrmMenuPrincipal : Form
    {
        //private List<Pasajero> listaPasajerosAux;
        private List<Vuelo> listaVuelos = new List<Vuelo>();
        //private string fecha;
        //List<VueloInternacional> listaVuelosInternacional = new List<VueloInternacional>();


        public FrmMenuPrincipal()
        {
            InitializeComponent();
            listaVuelos = DatosNegocio.ListaVuelos;

            //listaPasajerosAux = new List<Pasajero>()
            //{
            //    new Pasajero("Eduard", "Brito", 95645952, 31, EEquipaje.Bodega, true),
            //    new Pasajero("Jose", "Perez", 95123456, 36, EEquipaje.Mano, false),
            //};
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
            //fecha = dtpFechaIda.Value.ToShortDateString();

  
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
            //dtgVuelosInternacionales.Visible = true;
            //dtgVuelosInternacionales.Visible = true;
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
    }
}
