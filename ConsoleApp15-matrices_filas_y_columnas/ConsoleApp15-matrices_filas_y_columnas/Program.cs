using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15_matrices_filas_y_columnas
{
    /*
     * Crear una matriz de n * m filas (cargar n y m por teclado) 
     * Intercambiar la primer fila con la segunda. 
     * Imprimir luego la matriz.
    */
    
    internal class Matriz
    {
        private int[,] matriz;

        public void Cargar()
        {
            int columna, fila;
            Console.WriteLine("Ingrese la cantidad de filas de la matriz");
            fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
            columna = int.Parse(Console.ReadLine());

            matriz = new int[fila, columna];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Ingrese el elemento de la posicion: " + j + "," + i);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void IntercambiarFilas()
        {
            Console.WriteLine("INTERCAMBIANO FILAS DE LA MATRIZ.......");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int aux = matriz[0, j];
                matriz[0, j] = matriz[1,j];
                matriz[1, j] = aux;

            }
        }

        public void Imprimir()
        {
            Console.WriteLine(" El resulatado es :");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("| " + matriz[i,j]+" |");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            Matriz matriz= new Matriz();
            matriz.Cargar();
            matriz.IntercambiarFilas();
            matriz.Imprimir();



            Console.ReadKey();
        }
    }
}
