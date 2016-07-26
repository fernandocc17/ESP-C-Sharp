using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo11_Pila_generica
{
    class Pila<T>
    {
        const int TAMANIO = 10;
        T[] a=new T[TAMANIO];
        int tope = 0;

        public void agregar(T valor)
        {
            if (tope != TAMANIO)
            {
                a[tope++]=valor;
            }
        }

        public T sacar() {

            return a[tope--];
        }


    }
}
