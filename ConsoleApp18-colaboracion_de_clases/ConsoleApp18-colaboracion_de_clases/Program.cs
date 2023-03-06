using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18_colaboracion_de_clases
{
    /*
     * Plantear una clase Club y otra clase Socio.
     * La clase Socio debe tener los siguientes atributos privados:
     * nombre y la antigüedad en el club (en años). 
     * En el constructor pedir la carga del nombre y su antigüedad. 
     * La clase Club debe tener como atributos 3 objetos de la clase Socio.
     * Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.
     */
        public class Socio
        {
            private string nombre;
            private  int antiguedad;

            public Socio()
            {
                Console.WriteLine("Ingrese el nombre del socio");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la antiguedad del socio");
                antiguedad = int.Parse(Console.ReadLine());
            }
            public int Antigue()
            {
            return antiguedad;
            }
            public void Imprimir()
            {
                Console.WriteLine($"Nombre: {nombre} antiguedad: {antiguedad}");
            }
        }


    internal class Club
    {
        private Socio socio1,socio2,socio3;
        Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }
            
        public void SocioAntiguo()
        {
            Console.WriteLine("Socio mas Antiguo: ");
            if (socio1.Antigue() > socio2.Antigue() && socio1.Antigue() > socio3.Antigue()) 
            {
                socio1.Imprimir();
            }
            else
            {
                if (socio2.Antigue() > socio1.Antigue() && socio2.Antigue() > socio3.Antigue())
                {
                    socio2.Imprimir();
                }
                else
                {
                    socio3.Imprimir();
                }
            }
        }
        static void Main(string[] args)
        {
           Club club = new Club();
            club.SocioAntiguo();
            Console.ReadKey();
        }
    }
}
