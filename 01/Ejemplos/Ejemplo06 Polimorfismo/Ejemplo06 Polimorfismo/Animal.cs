using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo06_Polimorfismo
{
     abstract class Animal:Respiracion
    {
         abstract public void hablar();


         public abstract void respirar();
        
    }
}
