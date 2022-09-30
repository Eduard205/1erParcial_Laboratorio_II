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
        private List<Pasajero> listaPasajerosAux;
        private string fecha;


        public FrmMenuPrincipal()
        {
            InitializeComponent();

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            FrmLogin FrmLogin = new FrmLogin();
            FrmLogin.Show();
            this.Hide();
            
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {


            //List<Vuelo> listaVuelos = new List<Vuelo>();

            //listaPasajerosAux = new List<Pasajero>()
            //{
            //    new Pasajero("Eduard", "Brito", 95645952, 31, EEquipaje.Bodega, true),
            //    new Pasajero("Jose", "Perez", 95123456, 36, EEquipaje.Mano, false),
            //};

            fecha = dtpFechaIda.Value.ToShortDateString();

            //Vuelo vuelo1 = new Vuelo(fecha,EDestinoNacional.BuenosAires, EDestinoInternacional.Roma, listaPasajerosAux);
            //Vuelo vuelo2 = new Vuelo(fecha, EDestinoNacional.BuenosAires, EDestinoNacional.Tucuman, listaPasajerosAux);


            //listaVuelos.Add(vuelo1);
            //listaVuelos.Add(vuelo2);

            dataGridVuelo.DataSource = null;
            dataGridVuelo.DataSource = DatosNegocio.ListaVuelos;
            //dataGridVuelo.DataSource = listaPasajerosAux;
        }

        private void dataGridVuelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void dtpFechaIda_ValueChanged(object sender, EventArgs e)
        {
      

            //fecha = dtpFechaIda.Value.ToShortDateString();
            //dataGridVuelo.DataSource = null;
            //dataGridVuelo.DataSource = listaVuelos;
        }
    }
}
