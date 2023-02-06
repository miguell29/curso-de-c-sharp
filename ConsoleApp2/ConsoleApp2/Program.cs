using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado, perimetro;
            string linea;

            Console.WriteLine("ingrese un lado del cuadrado:");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            perimetro = lado * 4;
            Console.WriteLine("el perimetro del cuadrado es: ");
            Console.Write(perimetro);
            Console.ReadLine();
        }
    }
}
