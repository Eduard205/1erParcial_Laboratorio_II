using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum EDestinoNacional
    {
        BuenosAires,
        SantaRosa,
        Bariloche,
        Corrientes,
        Cordoba,
        Jujuy,
        Mendoza,
        Neuquen,
        Posadas,
        Iguazu,
        Salta,
        SantiagoDelEstero,
        Trelew,
        Tucuman,
        PuertoMadryn,
        Ushuaia
    }

    public enum EDestinoInternacional
    {
        Recife,
        Roma,
        Acapulco,
        Miami 
    }

    public class Vuelo
    {
        private EDestinoNacional origenNacional;
        private EDestinoNacional destinoNacional;
        private EDestinoInternacional destinoInternacional;
        private string horaPartida;
        private string horaLlegada;
        private int duracionVuelo;
        private Pasajero pasajero;

        public Vuelo(EDestinoNacional origenNacional, EDestinoNacional destinoNacional, EDestinoInternacional destinoInternacional, 
            string horaPartida, string horaLlegada, int duracionVuelo, Pasajero pasajero)
        {
            this.origenNacional = origenNacional;
            this.destinoNacional = destinoNacional;
            this.destinoInternacional = destinoInternacional;
            this.horaPartida = horaPartida;
            this.horaLlegada = horaLlegada;
            this.duracionVuelo = duracionVuelo;
            this.pasajero = pasajero;
        }
    }
}
