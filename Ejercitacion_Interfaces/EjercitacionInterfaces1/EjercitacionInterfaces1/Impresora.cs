using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitacionInterfaces1
{
    internal class Impresora
    {
        public List<Imprimible> ColaDeImpresion = new List<Imprimible>();

        public void ImprimirTodo()
        {
            foreach (var elemento in ColaDeImpresion)
            {
                elemento.Imprimir();
            }
        }
        public void AgregarImprimible(Imprimible documento)
        {
            ColaDeImpresion.Add(documento);
        }
    }
}
