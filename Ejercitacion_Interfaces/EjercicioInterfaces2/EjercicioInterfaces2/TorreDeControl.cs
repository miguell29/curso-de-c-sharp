using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces2
{
    internal class TorreDeControl
    {
        List<Ivolador> Voladores = new List<Ivolador>();

        public void VuelenTodos()
        {
            foreach (var item in Voladores)
            {
                item.Volar();
            }
        }

        public void AgregarVolador(Ivolador volador)
        {
            Voladores.Add(volador);
        }
    }
}
