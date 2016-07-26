using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo11_Pila_entera
{
    class Pila
    {
        private int[] arreglo=new int[5] ;
        private int pos = 0;
       
        public void push(int valor){
            arreglo[pos++] = valor;
        }
        public int pop(){
            return arreglo[--pos];
        }
    }

}
