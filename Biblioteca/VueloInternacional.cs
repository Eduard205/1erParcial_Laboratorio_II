using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VueloInternacional:Vuelo
    {
        private EDestinoNacional origenNacional;
        private EDestinoInternacional destinoInternacional;
        private List<Pasajero> listaPasajeros = new List<Pasajero>();


        public EDestinoNacional OrigenNacional { get => origenNacional; set => origenNacional = value; }
        public EDestinoInternacional DestinoInternacional { get => destinoInternacional; set => destinoInternacional = value; }

        public VueloInternacional(string fechaIda, string fechaVuelta, EDestinoNacional origenNacional, EDestinoInternacional destinoInternacional,
        string idAeronave, List<Pasajero> listaPasajeros) : base(fechaIda, fechaVuelta, idAeronave)
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
    }
}
