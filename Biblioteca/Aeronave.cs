using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Aeronave
    {
        private string matricula;
        private int cantidadAsientos;
        private int cantidadBaños;
        private int capacidadBodega;
        private static List<Aeronave> listaAeronaves;

        public Aeronave() { }
        public Aeronave(string matricula, int cantidadAsientos, int cantidadBaños, int capacidadBodega)
        {
            this.matricula = matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadBaños = cantidadBaños;
            this.capacidadBodega = capacidadBodega;
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public int CantidadAsientos
        {
            get { return cantidadAsientos; }
            set { cantidadAsientos = value; }
        }
        public int CantidadBaños
        {
            get { return cantidadBaños; }
            set { cantidadBaños = value; }
        }
        public int CapacidadBodega
        {
            get { return capacidadBodega; }
            set { capacidadBodega = value; }
        }

        public List<string> ListarMatriculas()
        {
            List<string> listaMatriculas = new List<string>();

            if (DatosNegocio.ListaAeronaves is not null)
            {
                foreach (Aeronave item in DatosNegocio.ListaAeronaves)
                {
                    listaMatriculas.Add(item.Matricula);

                }
            }
            return listaMatriculas;
        }

    }
}
