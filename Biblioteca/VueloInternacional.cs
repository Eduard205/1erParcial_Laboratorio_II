using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VueloInternacional : Vuelo
    {
        private EOrigenNacional origenNacional;
        private EDestinoInternacional destinoInternacional;
        private List<Pasajero> listaPasajeros;

        public List<Pasajero> ListaPasajeros { get => listaPasajeros; set => listaPasajeros = value; }
        public EOrigenNacional OrigenNacional { get => origenNacional; set => origenNacional = value; }
        public EDestinoInternacional DestinoInternacional { get => destinoInternacional; set => destinoInternacional = value; }

        public VueloInternacional() { }
        public VueloInternacional(string fechaPartida, EOrigenNacional origenNacional, EDestinoInternacional destinoInternacional,
        string idAeronave, bool esInternacional, List<Pasajero> listaPasajeros) : base(fechaPartida, idAeronave, esInternacional)
        {
            this.OrigenNacional = origenNacional;
            this.DestinoInternacional = destinoInternacional;
            listaPasajeros.AddRange(listaPasajeros);
            this.DuracionVuelo = numRandom.Next(8, 12);

            DateTime horaPartidaAux = RandomDiaHora();
            this.HoraPartida = horaPartidaAux.Hour.ToString();
            horaPartidaAux = horaPartidaAux.AddHours(Convert.ToDouble(duracionVuelo));
            this.HoraLlegada = horaPartidaAux.Hour.ToString();

        }
        public List<VueloInternacional> MostrarVuelos
        {
            get
            {
                List<VueloInternacional> listaAux = new List<VueloInternacional>();

                if (DatosNegocio.ListaVuelos is not null)
                {
                    foreach (Vuelo item in DatosNegocio.ListaVuelos)
                    {
                        if (item.GetType() == typeof(VueloInternacional))
                        {
                            listaAux.Add((VueloInternacional)item);
                        }
                    }
                }
                return listaAux;
            }
        }

        
    }
}
