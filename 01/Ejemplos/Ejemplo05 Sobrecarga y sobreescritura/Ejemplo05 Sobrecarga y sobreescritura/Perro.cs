using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo05_Sobrecarga_y_sobreescritura
{
    class Perro:Animal
    {
        public override void hablar()
        {
            MessageBox.Show("GUAU!");
        }

        public Perro ():base(0,null) 
        { 
        }
    }
}
