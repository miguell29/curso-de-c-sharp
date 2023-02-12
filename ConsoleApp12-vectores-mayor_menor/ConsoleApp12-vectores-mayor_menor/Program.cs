using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_vectores_mayor_menor
{
    /*
     
    Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro del vector 

     */
    internal class Prueba
    {
        private int[] Elementos;
        static void Main(string[] args)
        {
            Prueba prueba= new Prueba();
            prueba.CargarElementos();
            prueba.FindMajor();
            prueba.FindMinor();
            Console.ReadKey();
        }

        public void CargarElementos()
        {
            Console.WriteLine("Cuantos numeros desea ingresar?");
            Elementos = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < Elementos.Length; i++)
            {
                Console.WriteLine("Ingrese un número");
                Elementos[i] = int.Parse(Console.ReadLine());
            }
        }
        public void FindMajor()
        {
            int major = Elementos[0], repeat = 0;
            for (int i = 1; i < Elementos.Length; i++)
            {
                if (Elementos[i] > major)
                {
                    repeat = 0;
                    major= Elementos[i];
                }
                else
                {
                    if (Elementos[i] == major)
                    {
                        repeat++;
                    }
                }

            }
            Console.WriteLine("El numero mayor es " + major + " y se repite " + repeat + " veces.");
        }
        public void FindMinor()
        {
            int minor = Elementos[0], repeat = 0;
            for (int i = 1; i < Elementos.Length; i++)
            {
                if (Elementos[i] < minor)
                {
                    repeat = 0;
                    minor = Elementos[i];
                }
                else
                {
                    if (Elementos[i] == minor)
                    {
                        repeat++;
                    }
                }

            }
            Console.WriteLine("El numero menor es " + minor + " y se repite " + repeat + " veces.");
        }

    }
}
