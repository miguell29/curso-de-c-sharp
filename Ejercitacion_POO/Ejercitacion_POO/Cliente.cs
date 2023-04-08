using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion_POO
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private string dni;

        public String Nombre { get => nombre; set => nombre = value; }
        public String Apellido { get => apellido; set => apellido = value; }
        public String Dni { get => dni; set => dni = value; }

        public Cliente(String nombre, String apellido, String dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }
    }
}
