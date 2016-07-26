using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo06_Polimorfismo
{
    sealed class Perro : Animal
    {
       
        public override void hablar(){
        MessageBox.Show("Guau");
        }

    public override void respirar()
        {

            MessageBox.Show("Respiracion perruna");
        }
    }
}
