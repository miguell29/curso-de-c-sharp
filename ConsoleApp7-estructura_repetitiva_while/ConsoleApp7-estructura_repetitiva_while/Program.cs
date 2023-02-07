using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_estructura_repetitiva_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500,
             * realizar un programa que lea los sueldos que cobra cada empleado e informe 
             * cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300. 
             * Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.*/
            int sueldoTotal = 0, sueldoBajo = 0, sueldoAlto = 0, sueldo, empleado = 0, empleados;
            string entrada;
            Console.WriteLine("cuantos empleados tiene su empresea");
            entrada = Console.ReadLine();
            empleados = int.Parse(entrada);

            while(empleado < empleados)
            {
                Console.WriteLine("Ingrese el sueldo de un empleado");
                entrada = Console.ReadLine();
                sueldo = int.Parse(entrada);
                if (sueldo > 300) 
                {
                    sueldoAlto++;
                }
                else
                {
                    sueldoBajo++;
                }
                sueldoTotal += sueldo;
                empleado++;
            }

            Console.Write("Empleado que ganan entre $100 - $300: ");
            Console.WriteLine(sueldoBajo);
            Console.Write("Empleados que ganan mas de $300: ");
            Console.WriteLine(sueldoAlto);
            Console.Write("El importe total que la empresa gasta en sueldos para el personal es de: $");
            Console.WriteLine(sueldoTotal);
            Console.ReadKey();
        }
    }
}
