using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo02_Herencia
{
    class Gato:Animal
    {/*
        public String nombre;
        public int edad;
        public string sexo;
        public string raza;
        public string duenyo;
        */
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

/*        public void dormir()
        {
            System.Windows.Forms.MessageBox.Show("Estoy durmiendo");
        }

        public void jugar()
        {
            System.Windows.Forms.MessageBox.Show("Soy " + nombre + " y estoy jugando");
        }

        public void aparear() { 

        }
        public void correr() { 
        
        }*/

    }
}
