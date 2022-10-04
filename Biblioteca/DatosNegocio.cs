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
        public static List<Aeronave> ListaAeronaves { get => listaAeronaves; set => listaAeronaves = value; }

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
        /// <summary>
        /// Instancia las Aeronaves disponibles
        /// </summary>
        private static void InstanciarAeronaves()
        {
            ListaAeronaves = new List<Aeronave>()
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
        /// <summary>
        /// Instancia los vuelos Precargados
        /// </summary>
        private static void InstanciarVuelos()
        {
            ListaVuelos = new List<Vuelo>()
            {
                new VueloNacional(fechaPartida:"25/10/2022", origenNacional:EOrigenNacional.BuenosAires,
                destinoNacional:EDestinoNacional.Salta, idAeronave:"737600NA", false,
                new List<Pasajero>()
                {
                    new Pasajero("Eduard", "Brito", 95645952, 31, EEquipaje.Bodega, true),
                    new Pasajero("Jose", "Perez", 95123456, 36, EEquipaje.Mano, false),
                    new Pasajero("Maria", "Sanchez", 34567987, 40, EEquipaje.Bodega, false),
                    new Pasajero("Carlos","Rodriguez", 29465852, 47, EEquipaje.Mano, true),
                }),

                new VueloInternacional(fechaPartida:"15/10/2022", origenNacional:EOrigenNacional.BuenosAires,
                destinoInternacional:EDestinoInternacional.Acapulco, idAeronave:"777200IN", true,
                new List<Pasajero>()
                {
                    new Pasajero("Lucas", "Rodriguez", 35675345, 31, EEquipaje.Bodega, true),
                    new Pasajero("Ignacio", "Smirlian", 40678890, 25, EEquipaje.Mano, true),
                    new Pasajero("Ornela", "Curcio", 34789567, 33, EEquipaje.Bodega, false),
                    new Pasajero("Esteban","Prieto", 40456789, 24, EEquipaje.Mano, false),
                })
            };
        }
        /// <summary>
        /// Muestra la lista de Vuelos Internacionales
        /// </summary>
        /// <returns>List<VueloInternacional></returns>
        public static List<VueloInternacional> MostrarVuelosInternacional
        {
            get 
            {
                VueloInternacional mostrar = new VueloInternacional();
                return mostrar.MostrarVuelos; 
            }
        }
        /// <summary>
        /// Muestra la lista de Vuelos Nacionales
        /// </summary>
        /// <returns>List<VueloNacional></returns>
        public static List<VueloNacional> MostrarVuelosNacional
        {
            get
            {
                VueloNacional mostrar = new VueloNacional();
                return mostrar.MostrarVuelos;
            }
        }
        /// <summary>
        /// Retorna una lista de las matriculas de Aeronaves Nacionales
        /// </summary>
        /// <returns>List<string></returns>
        public static List<string> MostrarIdAeronaveNacional
        {
            get
            {
                List<string> listaAux = new List<string>();
                List<string> listaMatriculaNac = new List<string>();
                Aeronave mostrar = new Aeronave();
                listaAux = mostrar.ListarMatriculas();

                if (listaAux is not null)
                {
                    foreach (string item in listaAux)
                    {
                        if (item.Contains("NA"))
                        {
                            listaMatriculaNac.Add(item);
                        }
                    }
                }
                return listaMatriculaNac;
            }
        }
        /// <summary>
        /// Retorna una lista de las matriculas de Aeronaves Internacionales
        /// </summary>
        /// <returns>List<string></returns>
        public static List<string> MostrarIdAeronaveInternacional
        {
            get
            {
                List<string> listaAux = new List<string>();
                List<string> listaMatriculaInt = new List<string>();
                Aeronave mostrar = new Aeronave();
                listaAux = mostrar.ListarMatriculas();

                if(listaAux is not null)
                {
                    foreach (string item in listaAux)
                    {
                        if (item.Contains("IN"))
                        {
                            listaMatriculaInt.Add(item);
                        }
                    }
                }
                return listaMatriculaInt;
            }
        }
        /// <summary>
        /// Retorna una lista de los NroVuelos de Aeronaves Nacionales
        /// </summary>
        /// <returns>List<string></returns>
        public static List<string> ListarNroVuelosNacional
        {
            get
            {
                List<string> listaAux = new List<string>();
                List<string> listaAuxNroVueloNacional = new List<string>();
                VueloNacional listar = new VueloNacional();
                listaAuxNroVueloNacional = listar.ListarNroVuelo();

                if (listaAux is not null && listaAuxNroVueloNacional is not null)
                {
                    foreach (string item in listaAuxNroVueloNacional)
                    {
                            listaAux.Add(item);
                    }
                }
                else
                {
                    new Exception("Error en la lista de Nro de Vuelos");
                }
                return listaAux;
            }
        }
        /// <summary>
        /// Retorna una lista de los NroVuelos de Aeronaves Internacionales
        /// </summary>
        /// <returns>List<string></returns>
        public static List<string> ListarNroVuelosInternacional
        {
            get
            {
                List<string> listaAux = new List<string>();
                List<string> listaAuxNroVuelointernacional = new List<string>();
                VueloInternacional listar = new VueloInternacional();
                listaAuxNroVuelointernacional = listar.ListarNroVuelo();

                if (listaAux is not null && listaAuxNroVuelointernacional is not null)
                {
                    foreach (string item in listaAuxNroVuelointernacional)
                    {
                        listaAux.Add(item);
                    }
                }
                else
                {
                    new Exception("Error en la lista de Nro de Vuelos");
                }
                return listaAux;
            }
        }
        /// <summary>
        /// Valida que el dni este en el rango establecido
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Retorna un bool, true si el dni esta en el rango</returns>
        public static bool ValidarDni(int dni)
        {
            return dni > 10000000 && dni < 99999999;
        }

    }
}
