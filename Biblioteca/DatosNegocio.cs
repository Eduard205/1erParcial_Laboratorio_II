using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class DatosNegocio
    {
        private static List<Usuario> listaUsuarios;

        static DatosNegocio()
        {
            InstanciarUsuarios();
        }

        /// <summary>
        /// Instancia los usuarios Precargados
        /// </summary>
        private static void InstanciarUsuarios()
        {
            listaUsuarios = new List<Usuario>()
            {
                new Usuario(95645952,"Eduard Brito","Drago1"),
                new Usuario(95123456,"Jesus Gonzalez","Drago2"),
                new Usuario(35333999,"Victoria Plaquin","Drago3"),
                new Usuario(37123123,"Marina Azzara","Drago4"),
            };
        }

        /// <summary>
        /// Loguea al usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="password"></param>
        /// <returns>Retorna el usuario logueado</returns>
        public static Usuario LoguearUsuario(int idUsuario, string password)
        {
            foreach (Usuario item in listaUsuarios)
            {
                if (item.Dni == idUsuario && item.ComprobarPassword(password))
                {
                    return item;
                }
            }
            return null;
        }

    }
}
