using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum EEquipaje
    {
        Mano,
        Bodega     
    }
    public class Pasajero
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        private EEquipaje equipaje;
        private bool esPremium;

        public Pasajero(string nombre, string apellido, int dni, int edad, EEquipaje equipaje, bool esPremium)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.equipaje = equipaje;
            this.esPremium = esPremium;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public EEquipaje Equipaje
        {
            get { return equipaje; }
            set { equipaje = value; }
        }
        public bool EsPremium
        {
            get { return esPremium; }
            set { esPremium = value; }
        }
    }
}
