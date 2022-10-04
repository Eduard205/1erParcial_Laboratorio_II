using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string password;

        public Usuario(int idUsuario, string nombre, string password)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.password = password;
        }

        public int Dni
        {
            get { return idUsuario; }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        /// <summary>
        /// Comprueba el Password 
        /// </summary>
        /// <param name="datoIngresado"></param>
        /// <returns>Retorna true si el Password es correcto</returns>
        public bool ComprobarPassword(string datoIngresado)
        {
            return (!string.IsNullOrEmpty(datoIngresado) && datoIngresado.Trim() == password.Trim());
        }
    }
}
