using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Aeronave
    {
        private static string matricula;
        private static int cantidadAsientos;
        private static int cantidadBaños;
        private static int capacidadBodega;

        public static string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public static int CantidadAsientos
        {
            get { return cantidadAsientos; }
            set { cantidadAsientos = value; }
        }
        public static int CantidadBaños
        {
            get { return cantidadBaños; }
            set { cantidadBaños = value; }
        }
        public static int CapacidadBodega
        {
            get { return capacidadBodega; }
            set { capacidadBodega = value; }
        }

    }
}
