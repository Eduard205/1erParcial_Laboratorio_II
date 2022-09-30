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
        private static List<Aeronave> listaAeronaves;

        static DatosNegocio()
        {
            InstanciarUsuarios();
            InstanciarAeronaves();
        }

        /// <summary>
        /// Instancia los usuarios Precargados
        /// </summary>
        private static void InstanciarUsuarios()
        {
            listaUsuarios = new List<Usuario>()
            {
                new Usuario(idUsuario:9,nombre:"Eduard Brito",password:"1"),
                new Usuario(idUsuario:95123456,nombre:"Rhaenyra Targaryen",password:"drago2"),
                new Usuario(idUsuario:35333999,nombre:"Viserys Targaryen",password:"drago3"),
                new Usuario(idUsuario:37123123,nombre:"Aegon Targaryen",password:"drago4"),
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

        private static void InstanciarAeronaves() 
        {
            listaAeronaves = new List<Aeronave>()
            {
                new Aeronave(matricula:"737600NA",cantidadAsientos:132,cantidadBaños:3,capacidadBodega:100),
                new Aeronave(matricula:"737700NA",cantidadAsientos:149,cantidadBaños:4,capacidadBodega:110),
                new Aeronave(matricula:"737800NA",cantidadAsientos:189,cantidadBaños:5,capacidadBodega:140),
                new Aeronave(matricula:"737900NA",cantidadAsientos:180,cantidadBaños:5,capacidadBodega:130),
                new Aeronave(matricula:"777200IN",cantidadAsientos:305,cantidadBaños:6,capacidadBodega:305),
                new Aeronave(matricula:"777300IN",cantidadAsientos:368,cantidadBaños:7,capacidadBodega:368),
                new Aeronave(matricula:"7778XXIN",cantidadAsientos:350,cantidadBaños:7,capacidadBodega:350),
            };

        }

    }
}
