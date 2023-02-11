using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_estructura_repetitiva_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             En un banco se procesan datos de las cuentas corrientes de sus clientes
            De cada cuenta corriente se conoce: número de cuenta y saldo actual
            El ingreso de datos debe finalizar al ingresar un valor negativo en el número de cuenta.
            Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
            a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
            Estado de la cuenta:
            'Acreedor' si el saldo es >0.
			'Deudor' si el saldo es <0.
			'Nulo' si el saldo es =0.
             */

            int numCuenta;
            float saldo;
            string entrada, estadoCuenta;

            do
            {
                Console.WriteLine("Ingrese un número de cuenta (ponga un numero negativo si quiere cancelar la operación)");
                entrada= Console.ReadLine();
                numCuenta = Convert.ToInt32(entrada);
                if (numCuenta >= 0)
                {
                    Console.WriteLine("Ingrese el saldo de la cuenta");
                    entrada = Console.ReadLine();
                    saldo = float.Parse(entrada);
                
                    
                    if (saldo < 0)
                    {
                        estadoCuenta = "Deudor";
                    }
                    else
                    {
                        if (saldo > 0)
                        {
                            estadoCuenta = "Acreedor";
                        }
                        else
                        {
                            estadoCuenta = "Nulo";
                        }
                    }
                    Console.WriteLine("El estado de la cuenta numero: " + numCuenta + " es: " + estadoCuenta);
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("");
                }

            } while (numCuenta >= 0);
        }
    }
}
