using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 
 Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
 El valor acumulado de todos los elementos del vector.
 El valor acumulado de los elementos del vector que sean mayores a 36.
 Cantidad de valores mayores a 50.
 
 
 */
namespace ConsoleApp11_vectores
{
    internal class Valores
    {
        private int[] elementos;
        private int acumulacionTotal = 0, acumMayor = 0, mayores = 0;
        public void CargarValores()
        {
            elementos = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Ingresar un elemento");
                elementos[i] = int.Parse(Console.ReadLine());
                acumulacionTotal += elementos[i];
                if (elementos[i] > 36)
                {
                    acumMayor += elementos[i];
                }
                if (elementos[i] > 50)
                {
                    mayores++;
                }

            }
        }

        public void Imprimir()
        {
            Console.WriteLine("El valor acumulado de todos lo elementos es: " + acumulacionTotal);
            Console.WriteLine("El valor acumulado de los elementos mayores a 36 es: " + acumMayor);
            Console.WriteLine("La cantidad de elementos mayores a 50 es: " + mayores);

        }
        static void Main(string[] args)
        {
            Valores valores = new Valores();
            valores.CargarValores();
            valores.Imprimir();
            Console.ReadKey();
        }
    }
}
