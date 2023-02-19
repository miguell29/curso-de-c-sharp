using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_matriz
{
    /*Crear una matriz de 2 filas y 5 columnas. 
     * Realizar la carga de componentes por columna 
     * (es decir primero ingresar toda la primer columna, luego la segunda columna y así sucesivamente)
     * Imprimir luego la matriz.*/

    internal class Matriz
    {
        private int[,] matriz;

        public void Cargar()
        {
            matriz = new int[2, 5];
            
            for (int column = 0; column < 5; column++)
            {
                Console.WriteLine("Ingrese los datos de la columna " + column);
                for (int row = 0; row < 2; row++)
                {
                    Console.WriteLine("Ingrese un dato");
                    matriz[row, column] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Print()
        {
                    Console.WriteLine("La matriz resultante es :");
            for (int row = 0; row < 2; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    Console.Write(" - " + matriz[row, column]);
                }
                    Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Matriz matriz = new Matriz();
            matriz.Cargar();
            matriz.Print();
            Console.ReadKey();
        }
    }
}
