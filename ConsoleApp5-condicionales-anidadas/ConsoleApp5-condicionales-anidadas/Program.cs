using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_condicionales_anidadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Confeccionar un programa que permita cargar un número entero positivo de hasta tres cifras y muestre un mensaje indicando si tiene 1, 2, o 3 cifras. Mostrar un mensaje de error si el número de cifras es mayor.
            int numero;
            string entrada;
            Console.WriteLine("Ingrese un numero entero positivo de tres cifras o menos");
            entrada = Console.ReadLine();
            numero = int.Parse(entrada);

            if (numero / 100 > 0 && numero / 100 < 10)
            {
                Console.WriteLine("El número es de 3 cifras");
            }
            else if (numero / 10 > 0 && numero / 10 < 10)
            {
                Console.WriteLine("El número es de 2 cifras");
            }
            else if (numero > 0 && numero < 10)
            {
                Console.WriteLine("El número es de 1 cifra");
            }
            else
            {
                Console.WriteLine("ERROR - El numero ingresado no puede ser verificado");
            }

            Console.ReadKey();
        }
    }
}
