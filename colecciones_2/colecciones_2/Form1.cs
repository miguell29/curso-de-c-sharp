using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colecciones_2
{
    public partial class Form1 : Form
    {
        /*
         Desarrollar un programa para la simulación de un cajero automático.
Se cuenta con la siguiente información:
- Llegan clientes a la puerta del cajero cada 2 ó 3 minutos.
- Cada cliente tarda entre 2 y 4 minutos para ser atendido.

Obtener la siguiente información:
1 - Cantidad de clientes que se atienden en 10 horas.
2 - Cantidad de clientes que hay en cola después de 10 horas.
3 - Hora de llegada del primer cliente que no es atendido luego de 10 horas
        (es decir la persona que está primera en la cola cuando se cumplen 10 horas)
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            int cajeroOcupado = 0;
            int clienteLlegada = 2 + aleatorio.Next(0, 2);
            int clienteSalida = -1;
            int clientesAtendidos = 0;
            Queue<int> clientes = new Queue<int>();
            for (int minuto = 0; minuto < 600; minuto++)
            {
                if (minuto == clienteLlegada)
                {
                    if (cajeroOcupado == 0)
                    {
                        cajeroOcupado = 1;
                        clienteSalida = minuto + 2 + aleatorio.Next(0, 3);
                    }
                    else
                    {
                        clientes.Enqueue(minuto);
                    }

                    clienteLlegada = minuto + 2 + aleatorio.Next(0, 2);
                }

                if (minuto == clienteSalida)
                {
                    cajeroOcupado = 0;
                    clientesAtendidos++;
                    if (clientes.Count != 0)
                    {
                        clientes.Dequeue();
                        cajeroOcupado = 1;
                        clienteSalida = minuto + 2 + aleatorio.Next(0, 3);
                    }

                }
            }
            label1.Text = "Atendidos:" + clientesAtendidos.ToString();
            label2.Text = "En cola" + clientes.Count().ToString();
            label3.Text = "Minuto llegada:" + clientes.Dequeue().ToString();
        }
    }
}
