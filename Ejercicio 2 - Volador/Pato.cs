using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2___Volador
{
    class Pato: Animal, Volador
    {
        public void volador()
        {
            Console.WriteLine("Estoy volando como un pato... Cuak");
        }
    }
}
