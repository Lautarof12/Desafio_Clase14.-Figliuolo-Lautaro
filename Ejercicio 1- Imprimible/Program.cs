using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato contrato = new Contrato();
            Foto foto = new Foto();
            Documento documento = new Documento();
            Impresora impresora = new Impresora();
            Console.WriteLine("Bienvenido a la impresora");
            impresora.AgregarImprimible(documento);
            impresora.AgregarImprimible(foto);
            impresora.AgregarImprimible(contrato);
            impresora.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
