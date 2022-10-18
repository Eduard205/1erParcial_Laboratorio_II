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
        private bool wifi;

        public Aeronave() { }
        public Aeronave(string matricula, int cantidadAsientos, int cantidadBaños, int capacidadBodega, bool wifi)
        {
            this.Matricula = matricula;
            this.CantidadAsientos = cantidadAsientos;
            this.CantidadBaños = cantidadBaños;
            this.CapacidadBodega = capacidadBodega;
            this.TieneWifi = wifi;
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

        public bool TieneWifi { get => wifi; set => wifi = value; }

        public void DisminuirCantidadAsientos(int cantidadAsientos)
        {
            CantidadAsientos =- cantidadAsientos;
        }
        public void DisminuirCapacidadBodega(int cantidad)
        {
            CapacidadBodega = -cantidad;
        }

        /// <summary>
        /// Devuelve una lista de string con las matruclas de las Aeronaves
        /// </summary>
        /// <returns>List<string></returns>
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
        /// <summary>
        /// Sobrecarga del operador == para comparar Aeronaves por Matricula
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="matricula"></param>
        /// <returns>Retorna true si las matriculas de las Aeronaves son iguales</returns>
        public static bool operator ==(Aeronave a1, string matricula)
        {
            return a1.matricula == matricula;
        }
        /// <summary>
        /// Sobrecarga del operador !== para comparar Aeronaves por Matricula
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="matricula"></param>
        /// <returns>Retorna false si la matricula de las Aeronaves son iguales</returns>
        public static bool operator !=(Aeronave a1, string matricula)
        {
            return !(a1 == matricula);
        }
        /// <summary>
        /// Busca Aeronaves por Matricula
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="matricula"></param>
        /// <returns>Retorno el obejto de tipo Aeronave que contine la Matricula ingresado</returns>
        public static Aeronave BuscarAeronave(List<Aeronave> lista, string matricula)
        {
            foreach (Aeronave item in lista)
            {
                if (item == matricula)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
