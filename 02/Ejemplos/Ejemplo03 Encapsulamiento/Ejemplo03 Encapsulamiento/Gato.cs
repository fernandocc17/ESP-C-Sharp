using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo03_Encapsulamiento
{
    class Gato:Animal
    {
        public Gato(String nombre, int edad, String sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;

        }

        public void maullar()
        {
            System.Windows.Forms.MessageBox.Show("Estoy maullando");
        }

    }
}
