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
    public partial class FrmAltaVuelo : Form
    {
        private VueloNacional vueloNacional;
        private VueloInternacional vueloInternacional;
     
        public FrmAltaVuelo()
        {
            InitializeComponent();
        }

        private void FrmAltaVuelo_Load(object sender, EventArgs e)
        {
            radDestinoNacional.Checked = false;
            radDestinoInternacional.Checked = false;
            gBoxVueloNacional.Visible = false;
            gBoxVueloInternacional.Visible = false;
       
            cboOrigenNacional.DataSource = Enum.GetValues(typeof(EOrigenNacional));
            cboDestinoNacional.DataSource = Enum.GetValues(typeof(EDestinoNacional));
            cboOrigenNacionalInt.DataSource = Enum.GetValues(typeof(EOrigenNacional));
            cboDestinoInternacional.DataSource = Enum.GetValues(typeof(EDestinoInternacional));
            cboIdAeronaveNac.DataSource = DatosNegocio.MostrarIdAeronaveNacional;
            cboIdAeronaveInt.DataSource = DatosNegocio.MostrarIdAeronaveInternacional;
            
            cboOrigenNacional.SelectedItem = null;
            cboDestinoNacional.SelectedItem = null;
            cboOrigenNacionalInt.SelectedItem = null;
            cboDestinoInternacional.SelectedItem = null;
            cboIdAeronaveNac.SelectedItem = null;
            cboIdAeronaveInt.SelectedItem = null;
        }
        private void btnConfirmarAlta_Click(object sender, EventArgs e)
        {
            VueloNacional vueloNacional;
            VueloInternacional vueloInternacional;
            List<Pasajero> listaPasajeros;

            if (radDestinoNacional.Checked == true)
            {
                if (!string.IsNullOrEmpty(dtpFechaPartidaNacional.Value.Date.ToShortDateString()) &&
                    (cboOrigenNacional.SelectedItem is not null) &&
                    (cboDestinoNacional.SelectedItem is not null) &&
                    (!string.IsNullOrEmpty((string)cboIdAeronaveNac.SelectedItem)))
                {
                    string fechaPartida = dtpFechaPartidaNacional.Value.Date.ToShortDateString();
                    EOrigenNacional origen = (EOrigenNacional)cboOrigenNacional.SelectedItem;
                    EDestinoNacional destino = (EDestinoNacional)cboDestinoNacional.SelectedItem;
                    string idAeronave = (string)cboIdAeronaveNac.SelectedItem;
                    bool esInternacional = false;
                    listaPasajeros = new List<Pasajero>();

                    if (esInternacional is false && listaPasajeros is not null)
                    {
                        vueloNacional = new VueloNacional(fechaPartida, origen, destino, idAeronave, esInternacional, listaPasajeros);

                        MessageBox.Show($"Se dio de alta vuelo Nacional\n" +
                            $"Fecha de Partida: {fechaPartida}\n" +
                            $"Origen: {origen}\n" +
                            $"Destino: {destino}\n" +
                            $"IdAeronave: {idAeronave}\n" +
                            $"EsInternacional: {esInternacional}\n" +
                            $"Pasajeros: {listaPasajeros.Count}");

                        DatosNegocio.ListaVuelos.Add(vueloNacional);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Error, fallo la carga del vuelo Nacional");
                    }
                }
                else
                {
                    MessageBox.Show("Error, se deben completar TODOS los campos");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(dtpFechaPartidaInternacional.Value.Date.ToShortDateString()) &&
                    (cboOrigenNacionalInt.SelectedItem is not null) &&
                    (cboDestinoInternacional.SelectedItem is not null) &&
                    (!string.IsNullOrEmpty((string)cboIdAeronaveInt.SelectedItem)))
                {
                    string fechaPartida = dtpFechaPartidaInternacional.Value.Date.ToShortDateString();
                    EOrigenNacional origen = (EOrigenNacional)cboOrigenNacionalInt.SelectedItem;
                    EDestinoInternacional destino = (EDestinoInternacional)cboDestinoInternacional.SelectedItem;
                    string idAeronave = (string)cboIdAeronaveInt.SelectedItem;
                    bool esInternacional = false;
                    listaPasajeros = new List<Pasajero>();

                    if (esInternacional is false && listaPasajeros is not null)
                    {
                        vueloInternacional = new VueloInternacional(fechaPartida, origen, destino, idAeronave, esInternacional, listaPasajeros);

                        MessageBox.Show($"Se dio de alta vuelo Internacional\n" +
                            $"Fecha de Partida: {fechaPartida}\n" +
                            $"Origen: {origen}\n" +
                            $"Destino: {destino}\n" +
                            $"IdAeronave: {idAeronave}\n" +
                            $"EsInternacional: {esInternacional}\n" +
                            $"Pasajeros: {listaPasajeros.Count}");

                        DatosNegocio.ListaVuelos.Add(vueloInternacional);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Error, fallo la carga del vuelo Internacional");
                    }
                }
                else
                {
                    MessageBox.Show("Error, se deben completar TODOS los campos");
                }
            } 
        }
        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cboOrigenNacional_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboDestinoNacional_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboIdAeronaveNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboOrigenNacionalInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboDestinoInternacional_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboIdAeronaveInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void radDestinoNacional_CheckedChanged(object sender, EventArgs e)
        {
            if (radDestinoNacional.Checked == true)
            {
                gBoxVueloNacional.Visible = true;
                gBoxVueloInternacional.Visible = false;
            }
        }

        private void radDestinoInternacional_CheckedChanged(object sender, EventArgs e)
        {
            if (radDestinoInternacional.Checked == true)
            {
                gBoxVueloInternacional.Visible = true;
                gBoxVueloNacional.Visible = false;
            }
        }
    }
}