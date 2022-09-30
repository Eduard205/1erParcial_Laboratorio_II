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
        private string nroVuelo;
        private EDestinoNacional origenNacional;
        private EDestinoNacional destinoNacional;
        private EDestinoInternacional destinoInternacional;
        private string horaPartida;
        private string horaLlegada;
        private int duracionVuelo;
        private List<Pasajero> listaPasajeros = new List<Pasajero>();
        Random numRandom = new Random();

        public string NroVuelo { get => nroVuelo; set => nroVuelo = value; }
        public EDestinoNacional OrigenNacional { get => origenNacional; set => origenNacional = value; }
        public EDestinoNacional DestinoNacional { get => destinoNacional; set => destinoNacional = value; }
        public EDestinoInternacional DestinoInternacional { get => destinoInternacional; set => destinoInternacional = value; }
        public string HoraPartida { get => horaPartida; set => horaPartida = value; }
        public string HoraLlegada { get => horaLlegada; set => horaLlegada = value; }
        public int DuracionVuelo { get => duracionVuelo; set => duracionVuelo = value; }
        public List<Pasajero> ListaPasajeros { get => listaPasajeros; set => listaPasajeros = value; }
       

        private Vuelo()
        {
            this.NroVuelo = $"AR{numRandom.Next(1000, 9999).ToString()}";
            //this.horaPartida = RandomDiaHora().Hour.ToString();
            //DateTime horaPartidaAux = Convert.ToDateTime(horaPartida);
            //horaPartidaAux.AddHours(duracionVuelo);
            //this.horaLlegada = horaPartidaAux.Hour.ToString();


        }
        public Vuelo(EDestinoNacional origenNacional, EDestinoNacional destinoNacional, List<Pasajero> listaPasajeros):this()
        {
            this.OrigenNacional = origenNacional;
            this.DestinoNacional = destinoNacional;
            listaPasajeros.AddRange(listaPasajeros);
            this.DuracionVuelo = numRandom.Next(2, 4);

            DateTime horaPartidaAux = RandomDiaHora();
            this.HoraPartida = horaPartidaAux.Hour.ToString();
            horaPartidaAux.AddHours(DuracionVuelo);
            this.HoraLlegada = horaPartidaAux.Hour.ToString();
        }

        public Vuelo(EDestinoNacional origenNacional, EDestinoInternacional destinoInternacional, List<Pasajero> listaPasajeros):this()
        {
            this.OrigenNacional = origenNacional;
            this.DestinoInternacional = destinoInternacional;
            listaPasajeros.AddRange(listaPasajeros);
            this.DuracionVuelo = numRandom.Next(8, 12);

            DateTime horaPartidaAux = RandomDiaHora();
            this.HoraPartida = horaPartidaAux.Hour.ToString();
            horaPartidaAux.AddHours(DuracionVuelo);
            this.HoraLlegada = horaPartidaAux.Hour.ToString();
        }

        public DateTime RandomDiaHora() 
        { 
            DateTime inicio = new DateTime(2022, 9, 29, numRandom.Next(0, 24), 0, 0);
            int rango = (DateTime.Today - inicio).Days;
            inicio.AddDays(numRandom.Next(rango)).AddHours(numRandom.Next(0, 24)).AddMinutes(numRandom.Next(0, 0)).AddSeconds(numRandom.Next(0, 0));

            return inicio;
        }  
   
    }
}
