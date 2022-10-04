using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VueloNacional: Vuelo
    {
        private EOrigenNacional origenNacional;
        private EDestinoNacional destinoNacional;
        private List<Pasajero> listaPasajeros;

        public List<Pasajero> ListaPasajeros { get => listaPasajeros; set => listaPasajeros = value; }
        public EOrigenNacional OrigenNacional { get => origenNacional; set => origenNacional = value; }
        public EDestinoNacional DestinoNacional
        {
            get { return destinoNacional; }
            set { destinoNacional = value; }
        }

        public VueloNacional() { }

        public VueloNacional(string fechaPartida, EOrigenNacional origenNacional, EDestinoNacional destinoNacional,
            string idAeronave, bool esInternacional, List<Pasajero> listaPasajeros) : base(fechaPartida, idAeronave, esInternacional)
        {
            this.OrigenNacional = origenNacional;
            this.DestinoNacional = destinoNacional;
            listaPasajeros.AddRange(listaPasajeros);
            this.DuracionVuelo = numRandom.Next(2, 4);

            DateTime horaPartidaAux = RandomDiaHora();
            this.HoraPartida = horaPartidaAux.Hour.ToString();
            horaPartidaAux = horaPartidaAux.AddHours(Convert.ToDouble(duracionVuelo));
            this.HoraLlegada = horaPartidaAux.Hour.ToString();
        }

        /// <summary>
        /// Muestra la lista de vuelos Nacionales
        /// </summary>
        /// <returns>List<VueloNacional></returns>
        public List<VueloNacional> MostrarVuelos
        {
            get
            {
                List<VueloNacional> listaAux = new List<VueloNacional>();

                if (DatosNegocio.ListaVuelos is not null)
                {
                    foreach (Vuelo item in DatosNegocio.ListaVuelos)
                    {
                        if (item.GetType() == typeof(VueloNacional))
                        {
                            listaAux.Add((VueloNacional)item);
                        }
                    }
                }
                return listaAux;
            }
        }
        /// <summary>
        /// Genrera una lista con los Nro de Vuelo Nacionales
        /// </summary>
        /// <returns>List<string></returns>
        public override List<string> ListarNroVuelo()
        {
            {
                List<string> listaAux = new List<string>();

                if (DatosNegocio.ListaVuelos is not null)
                {
                    foreach (Vuelo item in DatosNegocio.ListaVuelos)
                    {
                        if (item.GetType() == typeof(VueloNacional))
                        {
                            listaAux.Add(item.NroVuelo);
                        }
                    }
                }
                else
                {
                    new Exception("Error en la lista de Vuelos");
                }
                return listaAux;
            }
        }
    }
}
