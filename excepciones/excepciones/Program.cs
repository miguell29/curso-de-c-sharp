using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones
{
    /*
     Declarar una clase 'Cliente' que represente un cliente de un banco. Definir las siguientes propiedades y métodos:

Cliente		
    Propiedades
        Nombre
        Monto
    métodos
        constructor
        Depositar
        Extraer
        Imprimir
Generar una excepción si se intenta extraer más dinero del que tiene la propiedad 'Monto'.
     */
    internal class Cliente
    {
        public string Nombre { get; set; }
        public float Monto { get; set; }
        public Cliente(string nombre, float monto) 
        {
            Nombre = nombre;
            Monto = monto;
        }
        public void Depositar(float dinero)
        {
            Monto += dinero;
        }
        public void Extraer(float dinero)
        {
            if (dinero < Monto)
                throw new Exception("No puede extraer mas dinero del que posee");
            Monto -= dinero;
        }
        public void Imprimir()
        {
            Console.WriteLine($@"El cliente {Nombre}
tiene un monto de: {Monto}");
        }
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Pedro", 10000);
            cliente1.Imprimir();
            cliente1.Depositar(2000);
            cliente1.Imprimir();
            try
            {
                cliente1.Extraer(5000);
                cliente1.Imprimir();
                cliente1.Extraer(3000);
                cliente1.Imprimir();
                cliente1.Extraer(70000);
                cliente1.Imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
