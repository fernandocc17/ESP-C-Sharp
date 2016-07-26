using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo10_Pila_entera
{
    class Pila
    {
        int[] a;
        int tope = 0;
        readonly int TAMANIO;

        public Pila(int tamanio) { 
            this.TAMANIO=tamanio;
            a = new int[TAMANIO];
        }

        public void agregar(int valor)
        {

            a[tope++]=valor;
        }

        public int sacar()
        {
            return a[--tope];
            
        }
    }
}
