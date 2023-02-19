using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16_matrices_y_vectores_paralelos
{
    /*
     * Se desea saber la temperatura media trimestral de cuatro paises. 
     * Para ello se tiene como dato las temperaturas medias mensuales de dichos paises.
     * Se debe ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.
     * Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.
     * a - Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
     * b - Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas.
     * c - Calcular la temperatura media trimestral de cada país.
     * d - Imprimir los nombres de los paises y las temperaturas medias trimestrales.
     * e - Imprimir el nombre del país con la temperatura media trimestral mayor.
    */
    internal class Temperatura
    {
        private string[] paises;
        private float[,] temperaturas;
        private float[] tempMedia;

        public void Cargar()
        {
            paises = new string[4];
            temperaturas = new float[4, 3];
            for (int i = 0; i < temperaturas.GetLength(0); i++)
            {
                Console.WriteLine("Ingrese el nombre del país:");
                paises[i] = Console.ReadLine();

                for (int j = 0; j < temperaturas.GetLength(1); j++)
                {
                    Console.WriteLine("Ingrese una temp media mensual");
                    temperaturas[i, j] = float.Parse(Console.ReadLine());
                }
            }
        }

        public void Imprimir()
        {
            for (int i = 0; i < temperaturas.GetLength(0); i++)
            {
                Console.WriteLine("País: " + paises[i] + "\ntemperaturas medias de los ultimos 3 meses:");
                for (int j = 0; j < temperaturas.GetLength(1); j++)
                {
                    Console.Write(" - "+ temperaturas[i,j]);
                }
                Console.WriteLine();
            }
        }
        
        public void CalcularTemperaturaMedia()
        {
            tempMedia = new float[4];
            for (int i = 0; i < temperaturas.GetLength(0); i++)
            {
                float suma = 0f;
                for (int j = 0; j < temperaturas.GetLength(1); j++)
                {
                    suma += temperaturas[i, j];
                }
                tempMedia[i]=suma/3;
            }
        }


        public void ImprimirTemperaturaMedia()
        {
            for (int i = 0; i < tempMedia.Length; i++)
            {
                Console.WriteLine("País: " + paises[i] + ", promedio de temperatura: " + tempMedia[i]);
            }
        }

        public void TemperaturaMediaMayor()
        {
            string pais = paises[0];
            float mayor = tempMedia[0];
            for (int i = 0; i < tempMedia.Length; i++)
            {
                if (tempMedia[i] > mayor)
                {
                    mayor = tempMedia[i];
                    pais = paises[i];
                }
            }
            Console.WriteLine("El pais con temp media mayor es: " + pais + "con una temperatura de: " + mayor);
        }
        static void Main(string[] args)
        {
            Temperatura temp = new Temperatura();
            temp.Cargar();
            temp.Imprimir();
            temp.CalcularTemperaturaMedia();
            temp.ImprimirTemperaturaMedia();
            temp.TemperaturaMediaMayor();
            Console.ReadKey();

        }
    }
}
