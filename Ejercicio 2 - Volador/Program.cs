using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2___Volador
{
    class Program
    {
        static void Main(string[] args)
        {
            Boeing747 boeing747 = new Boeing747();
            Pato pato = new Pato();
            Superman superman = new Superman();
            TorreDeControl torreDeControl = new TorreDeControl();
            Console.WriteLine("Bienvenido a la torre de control");

            torreDeControl.AgregarVolador(boeing747);
            torreDeControl.AgregarVolador(pato);
            torreDeControl.AgregarVolador(superman);
            torreDeControl.VuelanTodos();

            Console.ReadKey();

            

        }
    }
}
