using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo06_Polimorfismo
{
    sealed class Gato:Animal
    {

        public override void hablar() {
        MessageBox.Show("Miau");
        }

       public override void  respirar() {

            MessageBox.Show("Respiracion gatuna");
        }

    }
}
