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
        private static List<Vuelo> listaVuelos;

        public static List<Vuelo> ListaVuelos { get => listaVuelos; set => listaVuelos = value; }

        static DatosNegocio()
        {
            InstanciarUsuarios();
            InstanciarAeronaves();
            InstanciarVuelos();
        }

        /// <summary>
        /// Instancia los usuarios Precargados
        /// </summary>
        private static void InstanciarUsuarios()
        {
            listaUsuarios = new List<Usuario>()
            {
                new Usuario(idUsuario:1,nombre:"Eduard Brito",password:"1"),
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
                new Aeronave(matricula:"737600NA",cantidadAsientos:132,cantidadBaños:3,capacidadBodega:3742),
                new Aeronave(matricula:"737700NA",cantidadAsientos:149,cantidadBaños:4,capacidadBodega:4235),
                new Aeronave(matricula:"737800NA",cantidadAsientos:189,cantidadBaños:5,capacidadBodega:5371),
                new Aeronave(matricula:"737900NA",cantidadAsientos:180,cantidadBaños:5,capacidadBodega:5112),
                new Aeronave(matricula:"777200IN",cantidadAsientos:305,cantidadBaños:6,capacidadBodega:8662),
                new Aeronave(matricula:"777300IN",cantidadAsientos:368,cantidadBaños:7,capacidadBodega:10458),
                new Aeronave(matricula:"7778XXIN",cantidadAsientos:350,cantidadBaños:7,capacidadBodega:9940),
            };
        }
        private static void InstanciarVuelos()
        {
            ListaVuelos = new List<Vuelo>()
            {
                new VueloNacional(fechaIda:"25/10/2022",fechaVuelta:"30/10/2022", origenNacional:EDestinoNacional.BuenosAires, 
                destinoNacional:EDestinoNacional.Salta, idAeronave:"737600NA",
                new List<Pasajero>()
                {
                    new Pasajero("Eduard", "Brito", 95645952, 31, EEquipaje.Bodega, true),
                    new Pasajero("Jose", "Perez", 95123456, 36, EEquipaje.Mano, false),
                    new Pasajero("Maria", "Sanchez", 34567987, 40, EEquipaje.Bodega, false),
                    new Pasajero("Carlos","Rodriguez", 29465852, 47, EEquipaje.Mano, true),
                }),

                new VueloInternacional(fechaIda:"15/10/2022",fechaVuelta:"25/10/2022", origenNacional:EDestinoNacional.BuenosAires, 
                destinoInternacional:EDestinoInternacional.Acapulco, idAeronave:"777200IN",
                new List<Pasajero>()
                {
                    new Pasajero("Lucas", "Rodriguez", 35675345, 31, EEquipaje.Bodega, true),
                    new Pasajero("Ignacio", "Smirlian", 40678890, 25, EEquipaje.Mano, true),
                    new Pasajero("Ornela", "Curcio", 34789567, 33, EEquipaje.Bodega, false),
                    new Pasajero("Esteban","Prieto", 40456789, 24, EEquipaje.Mano, false),
                })
            };
        }

    }
}
