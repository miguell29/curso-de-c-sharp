using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_elif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se ingresan tres notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"
            int nota1, nota2, nota3;
            float promedio;
            string entrada;

            Console.WriteLine("---------------------->Calculadora de promedios<------------------------");
            Console.WriteLine("ingrese la nota 1");
            entrada = Console.ReadLine();
            nota1 = int.Parse(entrada);
            Console.WriteLine("ingrese la nota 2");
            entrada= Console.ReadLine();
            nota2= int.Parse(entrada);
            Console.WriteLine("Ingrese la nota 3");
            entrada = Console.ReadLine();
            nota3 = int.Parse(entrada);
            
            promedio = (nota1+nota2+nota3)/3;
            if (promedio >= 7)
            {
                Console.WriteLine("PROMOCIONADO!!!");
            }
            else
            {
                Console.Write("El promedio es: ");
                Console.WriteLine(promedio);
            }
            Console.ReadKey();
        }
    }
}
