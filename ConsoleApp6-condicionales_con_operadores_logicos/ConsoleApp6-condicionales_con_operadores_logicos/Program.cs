using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_condicionales_con_operadores_logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*De un operario se conoce su sueldo y los años de antigüedad.
            Se pide confeccionar un programa que lea los datos de entrada e informe:
            a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
            b) Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
            c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.*/

            int antiguedad;
            double sueldo;
            string entrada;

            Console.WriteLine("Ingrese el sueldo");
            entrada = Console.ReadLine();
            sueldo = int.Parse(entrada);
            Console.WriteLine("Ingrese la antiguedad");
            entrada = Console.ReadLine();
            antiguedad= int.Parse(entrada);

            if (sueldo < 500 && antiguedad >= 10)
            {
                sueldo += sueldo*0.2;
            }
            else
            {
                if (sueldo < 500 && antiguedad < 10)
                {
                    sueldo += sueldo * 0.05;
                }
            }
            Console.Write("El suledo a cobrar es: ");
            Console.WriteLine(sueldo);

            Console.ReadKey();




        }
    }
}
