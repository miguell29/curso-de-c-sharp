﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitacionInterfaces1
{
    internal class Documento : Imprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un documento de word");
        }
    }
}
