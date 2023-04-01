using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces2
{
    internal class Boing747 : Avion, Ivolador
    {
        private int horasDeVuelo = 0;

        public void Volar()
        {
            horasDeVuelo = horasDeVuelo + 15;
            Console.WriteLine("Estoy volando como un avion...");
        }
    }
}
