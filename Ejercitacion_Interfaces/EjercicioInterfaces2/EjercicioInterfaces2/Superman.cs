using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces2
{
    internal class Superman: SuperHeroe, Ivolador
    {
        private int experiencia = 0;

        public void Volar()
        {
            experiencia = experiencia + 3;
            Console.WriteLine("Estoy volando como un campeon...");
        }
    }
}
