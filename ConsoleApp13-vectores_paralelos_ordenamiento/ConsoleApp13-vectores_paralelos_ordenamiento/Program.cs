using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_vectores_paralelos_ordenamiento
{
    //Cargar en un vector los nombres de 5 paises y en otro vector paralelo
    //la cantidad de habitantes del mismo. Ordenar alfabéticamente e imprimir los resultados.
    //Por último ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir nuevamente.

    internal class Paises
    {
        private string[] paises = new string[5];
        private int[] habitantes = new int[5];

        public void Cargar()
        {
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del país: ");
                paises[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de habitantes que tiene " + paises[i]);
                habitantes[i] = int.Parse(Console.ReadLine());
            }
        }

        public void ordenar()
        {
            for (int i = 0; i < paises.Length-1; i++)
            {
                for (int j = 0; j < paises.Length-1; j++)
                {
                    if (paises[j].CompareTo(paises[j + 1]) > 0)
                    {
                        string auxp = paises[j];
                        paises[j] = paises[j+1];
                        paises[j+1] = auxp;

                        int auxh = habitantes[j];
                        habitantes[j] = habitantes[j + 1];
                        habitantes[j + 1] = auxh;
                    }
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Los países ingresados son:");
            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write(paises[i] + ": " + habitantes[i] + " millones de habitantes.\n");
            }
        }


        static void Main(string[] args)
        {
            Paises america = new Paises();
            america.Cargar();
            america.ordenar();
            america.Print();
            Console.ReadLine();
        }
    }
}
