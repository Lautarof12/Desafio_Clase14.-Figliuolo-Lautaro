using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_interfaces
{
    class Contrato: Imprimibles, Imprimible
    {
     public void imprimir()
        {
            Console.WriteLine("Soy un contrato muy legal");
        }
    }
}
