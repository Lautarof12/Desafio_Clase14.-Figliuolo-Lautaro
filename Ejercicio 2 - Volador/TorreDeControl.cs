using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2___Volador
{
    class TorreDeControl
    {
        List<Volador> voladores = new List<Volador>();
        public void VuelanTodos()
        {
            foreach(Volador c in voladores)
            {
                c.volador();
            }

        }
        public void AgregarVolador(Volador unVolador)
        {
            voladores.Add(unVolador);
        }

        }
    }

