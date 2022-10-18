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
        private string NroVuelo;
        private List<Pasajero> listaPasajerosNac = new List<Pasajero>();
        private List<Pasajero> listaPasajerosInt = new List<Pasajero>();
        public List<VueloNacional> listaVuelosNac = new List<VueloNacional>();
        public List<VueloInternacional> listaVuelosInt = new List<VueloInternacional>();

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
            listaVuelosNac = DatosNegocio.MostrarVuelosNacional;
            listaVuelosInt = DatosNegocio.MostrarVuelosInternacional;
        }
        public FrmMenuPrincipal(Usuario nombre) : this()
        {
            labNombreOperador.Text = $"Vendedor: {nombre.Nombre}, {DateTime.Now.ToString("dd-MM-yyyy")}";
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
            cboEquipajeNac.SelectedItem = null;
            cboEquipajeInt.SelectedItem = null;
            cboNroVueloInt.SelectedItem = null;
            cboNroVueloNac.SelectedItem = null;
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

            cboNroVueloInt.DataSource = DatosNegocio.ListarNroVuelosInternacional;
            cboNroVueloNac.DataSource = DatosNegocio.ListarNroVuelosNacional;
        }
        private void btnVenderPasajes_Click(object sender, EventArgs e)
        {
            gBoxVenderPasajes.Visible = true;
        }

        private void btnCargarPasajeroNac_Click(object sender, EventArgs e)
        {
            string patron = "[!\"·$%&/()=¿¡?'_:;,|@#€*+-.0123456789]";

            try
            {
                if ((!string.IsNullOrEmpty(txtNombreNac.Text.Trim()) &&
                    (!string.IsNullOrEmpty(txtApellidoNac.Text.Trim())) &&
                    (!string.IsNullOrEmpty(txtEdadNac.Text.Trim())) &&
                    (!string.IsNullOrEmpty(txtDniNac.Text.Trim()))) &&
                    (cboEquipajeNac.SelectedItem is not null) &&
                    (radSiPremiumNac.Checked == true || radNoPremiumNac.Checked == true) &&
                    (!string.IsNullOrEmpty((string)cboNroVueloNac.SelectedItem)))
                {
                    if (int.TryParse(txtDniNac.Text, out dni) && DatosNegocio.ValidarDni(Dni) && int.TryParse(txtEdadNac.Text, out edad) &&
                        (!Regex.IsMatch(txtNombreNac.Text, patron)) &&
                        (!Regex.IsMatch(txtApellidoNac.Text, patron)) &&
                        (Dni > 0 && Edad >= 1))
                    {
                        NroVuelo = (string)cboNroVueloNac.SelectedItem;
                        Nombre = txtNombreNac.Text;
                        Apellido = txtApellidoNac.Text;
                        Dni = int.Parse(txtDniNac.Text);
                        Edad = int.Parse(txtEdadNac.Text);
                        Equipaje = (EEquipaje)cboEquipajeNac.SelectedItem;

                        if (radSiPremiumNac.Checked == true)
                        {
                            EsPremium = true;
                        }
                        else
                        {
                            EsPremium = false;
                        }

                        dtgCargarPasajero.Rows.Add(NroVuelo, Nombre, Apellido, Dni, Edad, Equipaje, EsPremium);

                        listaPasajerosNac.Add(new Pasajero(NroVuelo, Nombre, Apellido, Dni, Edad, Equipaje, EsPremium));
                        LimpiarCamposVentaVueloNacional();
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
        private void btnCargarPasajeroInt_Click(object sender, EventArgs e)
        {
            string patron = "[!\"·$%&/()=¿¡?'_:;,|@#€*+-.0123456789]";

            try
            {
                if ((!string.IsNullOrEmpty(txtNombreInt.Text.Trim()) &&
                    (!string.IsNullOrEmpty(txtApellidoInt.Text.Trim())) &&
                    (!string.IsNullOrEmpty(txtEdadInt.Text.Trim())) &&
                    (!string.IsNullOrEmpty(txtDniInt.Text.Trim()))) &&
                    (cboEquipajeInt.SelectedItem is not null) &&
                    (radSiPremiumInt.Checked == true || radNoPremiumInt.Checked == true) &&
                    (!string.IsNullOrEmpty((string)cboNroVueloInt.SelectedItem)))
                {
                    if (int.TryParse(txtDniInt.Text, out dni) && DatosNegocio.ValidarDni(Dni) && int.TryParse(txtEdadInt.Text, out edad) &&
                         (!Regex.IsMatch(txtNombreInt.Text, patron)) &&
                        (!Regex.IsMatch(txtApellidoInt.Text, patron)) &&
                        (Dni > 0 && Edad >= 1))
                    {
                        NroVuelo = (string)cboNroVueloInt.SelectedItem;
                        Nombre = txtNombreInt.Text;
                        Apellido = txtApellidoInt.Text;
                        Dni = int.Parse(txtDniInt.Text);
                        Edad = int.Parse(txtEdadInt.Text);
                        Equipaje = (EEquipaje)cboEquipajeInt.SelectedItem;

                        if (radSiPremiumInt.Checked == true)
                        {
                            EsPremium = true;
                        }
                        else
                        {
                            EsPremium = false;
                        }

                        dtgCargarPasajero.Rows.Add(NroVuelo, Nombre, Apellido, Dni, Edad, Equipaje, EsPremium);
                        listaPasajerosInt.Add(new Pasajero(NroVuelo, Nombre, Apellido, Dni, Edad, Equipaje, EsPremium));
                        LimpiarCamposVentaVueloInternacional();
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

        private void cboNroVueloInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboEquipajeInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboNroVueloNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboEquipajeNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void radInternacional_CheckedChanged(object sender, EventArgs e)
        {
            if (radInternacional.Checked == true)
            {
                gBoxVueloInternacional.Visible = true;
                gBoxVueloNacional.Visible = false;
            }
        }

        private void radNacional_CheckedChanged(object sender, EventArgs e)
        {
            if (radNacional.Checked == true)
            {
                gBoxVueloNacional.Visible = true;
                gBoxVueloInternacional.Visible = false;
            }
        }

        private void radSiPremiumInt_CheckedChanged(object sender, EventArgs e)
        {
            if (radSiPremiumInt.Checked == true)
            {
                radNoPremiumInt.Checked = false;
            }
        }

        private void radNoPremiumInt_CheckedChanged(object sender, EventArgs e)
        {
            if (radNoPremiumInt.Checked == true)
            {
                radSiPremiumInt.Checked = false;
            }
        }

        private void radSiPremiumNac_CheckedChanged(object sender, EventArgs e)
        {
            if (radSiPremiumNac.Checked == true)
            {
                radNoPremiumNac.Checked = false;
            }
        }

        private void radNoPremiumNac_CheckedChanged(object sender, EventArgs e)
        {
            if (radNoPremiumNac.Checked == true)
            {
                radSiPremiumNac.Checked = false;
            }
        }

        private void radSiWifiInt_CheckedChanged(object sender, EventArgs e)
        {
            if (radSiWifiInt.Checked == true)
            {
                radNoWifiInt.Checked = false;

                cboNroVueloInt.DataSource = DatosNegocio.ListarNroVuelosInternacionalConWifi();
            }
        }

        private void radNoWifiInt_CheckedChanged(object sender, EventArgs e)
        {
            if (radNoWifiInt.Checked == true)
            {
                radSiWifiInt.Checked = false;

                cboNroVueloInt.DataSource = DatosNegocio.ListarNroVuelosInternacionalSinWifi();
            }
        }

        private void radSiWifiNac_CheckedChanged(object sender, EventArgs e)
        {
            if (radSiWifiNac.Checked == true)
            {
                radNoWifiNac.Checked = false;

                cboNroVueloNac.DataSource = DatosNegocio.ListarNroVuelosNacionalConWifi();
            }
        }

        private void radNoWifiNac_CheckedChanged(object sender, EventArgs e)
        {
            if (radNoWifiNac.Checked == true)
            {
                radSiWifiNac.Checked = false;

                cboNroVueloNac.DataSource = DatosNegocio.ListarNroVuelosNacionalSinWifi();
            }
        }

        private void btnCerrarVentaPasaje_Click(object sender, EventArgs e)
        {
            gBoxVenderPasajes.Visible = false;
            dtgCargarPasajero.Rows.Clear();
            LimpiarCamposVentaVueloInternacional();
            LimpiarCamposVentaVueloNacional();

        }

        public void LimpiarCamposVentaVueloInternacional()
        {
            txtNombreInt.Text = null;
            txtApellidoInt.Text = null;
            txtDniInt.Text = null;
            txtEdadInt.Text = null;
            cboEquipajeInt.SelectedItem = null;
            cboNroVueloInt.SelectedItem = null;
            radSiPremiumInt.Checked = false;
            radNoPremiumInt.Checked = false;
            radSiWifiInt.Checked = false;
            radNoWifiInt.Checked = false;
        }
        public void LimpiarCamposVentaVueloNacional()
        {
            txtNombreNac.Text = null;
            txtApellidoNac.Text = null;
            txtDniNac.Text = null;
            txtEdadNac.Text = null;
            cboEquipajeNac.SelectedItem = null;
            cboNroVueloNac.SelectedItem = null;
            radSiPremiumNac.Checked = false;
            radNoPremiumNac.Checked = false;
            radSiWifiNac.Checked = false;
            radNoWifiNac.Checked = false;
        }

        private void btnAgregarPasajerosAVuelo_Click(object sender, EventArgs e)
        {
            if (listaPasajerosNac.Count == 0 && listaPasajerosInt.Count == 0)
            {
                MessageBox.Show("Aún no ha cargado pasajeros");
            }

            if (listaPasajerosNac.Count > 0 && listaPasajerosNac is not null)
                {
                    foreach (VueloNacional item in listaVuelosNac)
                    {
                        foreach (Pasajero item2 in listaPasajerosNac)
                        {
                            if (item.NroVuelo == item2.NroVuelo)
                            {
                                if (Aeronave.BuscarAeronave(DatosNegocio.ListaAeronaves, item.IdAeronave).CantidadAsientos > listaPasajerosNac.Count())
                                {
                                    Aeronave.BuscarAeronave(DatosNegocio.ListaAeronaves, item.IdAeronave).DisminuirCantidadAsientos(listaPasajerosNac.Count());

                                    if (item2.Equipaje == EEquipaje.Bodega)
                                    {
                                        if (item2.EsPremium)
                                        {
                                            Aeronave.BuscarAeronave(DatosNegocio.ListaAeronaves, item.IdAeronave).DisminuirCapacidadBodega(42);
                                        }
                                        else
                                        {
                                            Aeronave.BuscarAeronave(DatosNegocio.ListaAeronaves, item.IdAeronave).DisminuirCapacidadBodega(25);
                                        }
                                    }
                                }
                                item.ListaPasajeros.AddRange(listaPasajerosNac);
                                MessageBox.Show($"Se agregaron los pasajeros al Vuelo Nacional Nro: {item.NroVuelo}");
                            }
                        }
                    }
                   
                }

                if (listaPasajerosInt.Count > 0 && listaPasajerosInt is not null)
                {
                    foreach (VueloInternacional item in listaVuelosInt)
                    {
                        foreach (Pasajero item2 in listaPasajerosInt)
                        {
                            if (item.NroVuelo == item2.NroVuelo)
                            {
                                if (item.NroVuelo == item2.NroVuelo)
                                {
                                    if (Aeronave.BuscarAeronave(DatosNegocio.ListaAeronaves, item.IdAeronave).CantidadAsientos > listaPasajerosInt.Count())
                                    {
                                        Aeronave.BuscarAeronave(DatosNegocio.ListaAeronaves, item.IdAeronave).DisminuirCantidadAsientos(listaPasajerosInt.Count());

                                        if (item2.Equipaje == EEquipaje.Bodega)
                                        {
                                            if (item2.EsPremium)
                                            {
                                                Aeronave.BuscarAeronave(DatosNegocio.ListaAeronaves, item.IdAeronave).DisminuirCapacidadBodega(42);
                                            }
                                            else
                                            {
                                                Aeronave.BuscarAeronave(DatosNegocio.ListaAeronaves, item.IdAeronave).DisminuirCapacidadBodega(25);
                                            }
                                        }
                                    }
                                    item.ListaPasajeros.AddRange(listaPasajerosInt);

                                    MessageBox.Show($"Se agregaron los pasajeros al Vuelo Internacional Nro: {item.NroVuelo}");
                                }
                            }
                        }
                    }
             
                }
                dtgCargarPasajero.Rows.Clear();   
        }

        private void btnLimpiarListaPasajeros_Click(object sender, EventArgs e)
        {
                listaPasajerosNac.Clear();
                listaPasajerosInt.Clear();
                dtgCargarPasajero.Rows.Clear();
        }
        
    }
}

