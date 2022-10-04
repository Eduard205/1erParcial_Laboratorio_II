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
