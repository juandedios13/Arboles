using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Nodo
    {
        public int Dato;
        public Nodo Izquierdo;
        public Nodo Derecho;
        public Nodo Padre;
        public int Nivel;
        public int Altura;

        public Nodo(int Dato)
        {
            this.Dato = Dato;
            Izquierdo = null;
            Derecho = null;
            Padre = null;
            this.Altura = 0;
        }
    }
}
