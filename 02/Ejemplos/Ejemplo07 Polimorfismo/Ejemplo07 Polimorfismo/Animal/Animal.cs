using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo05_Abstract_y_Sealed
{
    abstract class Animal
    {
        private String a_nombre;
        private readonly int edad;
        private string a_sexo;
        protected string raza;
        protected string duenyo;

      
        protected String sexo
        {
            get
            {
                return a_sexo;
            }
            set
            {
                if (value.Equals("HOMBRE") || value.Equals("MUJER"))
                    a_sexo = value;

            }
        }
        protected String nombre
        {
            get
            {
                return a_nombre;
            }
            set
            {
                a_nombre = value;
            }
        }

          public Animal(String nombre, int edad, String sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }


        protected internal virtual void dormir()
        {
         
            System.Windows.Forms.MessageBox.Show("Estoy durmiendo");
        }

        protected internal void jugar()
        {
            System.Windows.Forms.MessageBox.Show("Soy " + nombre + " y estoy jugando");
        }

        protected internal abstract void aparear();
       
        protected internal void correr()
        {

        }
    }
}
