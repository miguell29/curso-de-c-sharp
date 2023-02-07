using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_estructura_repetitiva_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que lea los lados de n triángulos, e informar:
            a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad.*/
            int triangulos, tEscaleno = 0, tIsosceles = 0, tEquilatero = 0, lado1, lado2, lado3;
            string entrada;

            Console.WriteLine("Ingrese la cantidad de triangulos que quiere analizar");
            entrada = Console.ReadLine();
            triangulos = int.Parse(entrada);

            for (int triangulo = 1; triangulo <= triangulos; triangulo++)
            {
                Console.Write("Ingrese los lados del triangulo n° ");
                Console.WriteLine(triangulo);
                Console.WriteLine("lado 1:");
                lado1 = int.Parse(Console.ReadLine());
                Console.WriteLine("lado 2:");
                lado2 = int.Parse(Console.ReadLine());
                Console.WriteLine("lado 3:");
                lado3 = int.Parse(Console.ReadLine());

                if (lado1 == lado2 && lado1 == lado3)
                {
                    tEquilatero++;
                    Console.WriteLine("Es un triangulo equilatero");
                }
                else
                {
                    if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    {
                        tIsosceles++;
                        Console.WriteLine("Es un triangulo isosceles");
                    }
                    else
                    {
                        tEscaleno++;
                        Console.WriteLine("Es un triangulo escaleno");
                    }
                }

            }
            Console.Write("cantidad de triangulos equilateros: ");
            Console.WriteLine(tEquilatero);

            Console.Write("cantidad de triangulos isosceles: ");
            Console.WriteLine(tIsosceles);

            Console.Write("cantidad de triangulos escaleno: ");
            Console.WriteLine(tEscaleno);


            if (tEquilatero < tIsosceles && tEquilatero < tEscaleno)
            {
                Console.Write("Existe una menor cantidad de triangulos Equilateros: ");
                Console.WriteLine(tEquilatero);
            }
            else
            {
                if (tIsosceles < tEscaleno)
                {
                    Console.Write("Existe una menor cantidad de triangulos Isosceles: ");
                    Console.WriteLine(tIsosceles);
                }
                else
                {
                    Console.Write("Existe una menor cantidad de triangulos Escalenos: ");
                    Console.WriteLine(tEscaleno);
                }
            }

            Console.ReadKey();
        }
    }
}
