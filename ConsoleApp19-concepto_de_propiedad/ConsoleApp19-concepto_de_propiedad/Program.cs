using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19_concepto_de_propiedad
{
    /*Plantear una clase Club y otra clase Socio.
     * La clase Socio debe tener los siguientes atributos privados:
     * nombre y la antigüedad en el club (en años) 
     * Definir dos propiedades para poder acceder al nombre y la antigüedad del socio
     * (no permitir cargar un valor negativo en la antigüedad). 
     * La clase Club debe tener como atributos 3 objetos de la clase Socio. 
     * Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.
     */

    public class Socio
    {
        private string nombre;
        private int antiguedad;
        public string Nombre 
        { 
            get 
            { 
                return nombre; 
            } 
            set 
            {
                nombre = value;
            }
        }
        public int Antiguedad
        {
            get 
            { 
            return antiguedad;
            }
            set
            {
                if (value > 0)
                {

                antiguedad = value;
                }
                else
                {
                    antiguedad = 0;
                    Console.WriteLine("Ingrese un valor válido para la antiguedad");
                }
            }
        }
        public Socio()
        {
            Console.WriteLine("Ingrese el nombre del socio");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la antiguedad");
            Antiguedad = int.Parse(Console.ReadLine());
        }

        
    }


    internal class Club
    {
        private Socio socio1,socio2, socio3;

        public Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public void SocioMayor()
        {
            Console.WriteLine("--------------SOCIO MAS ANTIGUO---------------");
            if( socio1.Antiguedad > socio2.Antiguedad && socio1.Antiguedad > socio3.Antiguedad) 
            {
                Console.WriteLine($"Nombre: {socio1.Nombre} ; antiguedad: {socio1.Antiguedad}");
            }
            else
            {
                if (socio2.Antiguedad > socio1.Antiguedad && socio2.Antiguedad > socio3.Antiguedad)
                {
                    Console.WriteLine($"Nombre: {socio2.Nombre} ; antiguedad: {socio2.Antiguedad}");
                }
                else
                {
                    Console.WriteLine($"Nombre: {socio3.Nombre} ; antiguedad: {socio3.Antiguedad}");
                }
            }
        }

        public void MostrarSocios()
        {
            Console.WriteLine("-----------Socios Actuales-----------");
            Console.WriteLine($"Nombre: {socio1.Nombre} ; antiguedad: {socio1.Antiguedad}");
            Console.WriteLine($"Nombre: {socio2.Nombre} ; antiguedad: {socio2.Antiguedad}");
            Console.WriteLine($"Nombre: {socio3.Nombre} ; antiguedad: {socio3.Antiguedad}");
        }

        static void Main(string[] args)
        {
            Club club = new Club();
            club.MostrarSocios();
            club.SocioMayor();
            Console.ReadKey();
        }
    }
}
