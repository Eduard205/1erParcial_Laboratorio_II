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

    public abstract class Vuelo
    {
        protected string nroVuelo;
        protected string fechaIda;
        protected string fechaVuelta;
        protected string horaPartida;
        protected string horaLlegada;
        protected int duracionVuelo;
        protected Random numRandom = new Random();
        protected string idAeronave;
  
        public string NroVuelo
        {
            get => nroVuelo;
            set => nroVuelo = value;
        }
        public string FechaIda { get => fechaIda; set => fechaIda = value; }
        public string FechaVuelta { get => fechaVuelta; set => fechaVuelta = value; }
        public string HoraPartida { get => horaPartida; set => horaPartida = value; }
        public string HoraLlegada { get => horaLlegada; set => horaLlegada = value; }
        public int DuracionVuelo { get => duracionVuelo; set => duracionVuelo = value; }
        public string IdAeronave { get => idAeronave; set => idAeronave = value; }

        protected Vuelo()
        {
            this.NroVuelo = $"AR{numRandom.Next(1000, 9999).ToString()}";
        }

        protected Vuelo(string fechaIda, string fechaVuelta, string idAeronave):this()
        {
            this.FechaIda = fechaIda;
            this.FechaVuelta = fechaVuelta;
            this.IdAeronave = idAeronave;
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
