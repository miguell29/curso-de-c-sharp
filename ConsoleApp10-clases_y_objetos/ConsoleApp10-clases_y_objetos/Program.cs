using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Confeccionar una clase que represente un empleado.
 Definir como atributos su nombre y su sueldo. 
 Confeccionar los métodos para la carga, otro para imprimir 
 sus datos y por último uno que imprima un mensaje si debe 
 pagar impuestos (si el sueldo supera a 3000)
 */







namespace ConsoleApp10_clases_y_objetos
{
    internal class Empleado
    {
        private string nombre;
        private int sueldo;

        public void Inicializar()
        {
            Console.WriteLine("ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese el sueldo");
            sueldo = int.Parse(Console.ReadLine());
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("datos del empleado");
            Console.WriteLine("nombre: " + nombre + " ; sueldo: " + sueldo);
        }

        public void Impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("No debe pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.Inicializar();    
            empleado1.ImprimirDatos();
            empleado1.Impuestos();
            Console.ReadKey();
        }
    }
}
