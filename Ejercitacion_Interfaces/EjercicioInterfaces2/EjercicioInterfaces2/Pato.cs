using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces2
{
    internal class Pato : Animal, Ivolador
    {
        private int energia = 100;

        public void Volar()
        {
            energia = energia - 5;
            Console.WriteLine("Estoy volando como un Pato... ¡cuak!");
        }
    }
}
