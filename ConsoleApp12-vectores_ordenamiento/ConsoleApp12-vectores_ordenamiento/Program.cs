using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_vectores_ordenamiento
{
    //Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
    internal class Sueldos
    {
        private int[] sueldos;

        public void Cargar()
        {
            Console.WriteLine("¿cuantos sueldos va a a ingresar?");
            sueldos = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine("Ingrese un sueldo");
                sueldos[i] = int.Parse(Console.ReadLine());
            }
        }

        public void OrdenarMayor()
        {
            for (int i = 0; i < sueldos.Length-1; i++)
            {
                for (int j = 0; j < sueldos.Length-1; j++)
                {
                    if (sueldos[j] < sueldos[j+1])
                    {
                        int aux = sueldos[j];
                        sueldos[j] = sueldos[j + 1];
                        sueldos[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("Los sueldos ordenados de mayor a menor son:");
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write(" - " + sueldos[i]);
            }
            Console.WriteLine("");
        }

        public void OrdenarMenor()
        {
            for (int i = 0; i < sueldos.Length - 1; i++)
            {
                for (int j = 0; j < sueldos.Length - 1; j++)
                {
                    if (sueldos[j] > sueldos[j + 1])
                    {
                        int aux = sueldos[j];
                        sueldos[j] = sueldos[j + 1];
                        sueldos[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("Los sueldos ordenados de menor a mayor son:");
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write(" - " + sueldos[i]);
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Sueldos salarios = new Sueldos();
            salarios.Cargar();
            salarios.OrdenarMayor();
            salarios.OrdenarMenor();
            Console.ReadKey();
        }    
    }
}
