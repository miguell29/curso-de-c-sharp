using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, multiplicacion;
            string linea;

            Console.WriteLine("Ingrese cuatro números");
            linea = Console.ReadLine();
            num1= int.Parse(linea);
            linea= Console.ReadLine();
            num2= int.Parse(linea);
            linea= Console.ReadLine();
            num3= int.Parse(linea);
            linea= Console.ReadLine();
            num4= int.Parse(linea);

            suma = num1 + num2;
            multiplicacion = num3 * num4;
            Console.Write("la suma del primero y el segundo es: ");
            Console.WriteLine(suma);
            Console.Write("La multiplicacion del tercero y el cuarto es: ");
            Console.WriteLine(multiplicacion);
            Console.ReadKey();
        }
    }
}
