using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VueloNacional: Vuelo
    {
        private EDestinoNacional origenNacional;
        private EDestinoNacional destinoNacional;
        private List<Pasajero> listaPasajeros = new List<Pasajero>();
      

        public EDestinoNacional OrigenNacional { get => origenNacional; set => origenNacional = value; }
        public EDestinoNacional DestinoNacional
        {
            get { return destinoNacional; }
            set { destinoNacional = value; }
        }

        public VueloNacional(string fechaIda, string fechaVuelta, EDestinoNacional origenNacional, EDestinoNacional destinoNacional, 
            string idAeronave, List<Pasajero> listaPasajeros) : base(fechaIda, fechaVuelta, idAeronave)
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

    }
}
