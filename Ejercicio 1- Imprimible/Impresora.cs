using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_interfaces
{
    class Impresora
    {
        List<Imprimible> ColaDeImpresion = new List<Imprimible>();
        public void ImprimirTodo()
        {
            foreach(Imprimible c in ColaDeImpresion)
            {
                c.imprimir();
            }
        }
        public void AgregarImprimible(Imprimible unImprimible)
        {
            ColaDeImpresion.Add(unImprimible);
        }
    }
}
