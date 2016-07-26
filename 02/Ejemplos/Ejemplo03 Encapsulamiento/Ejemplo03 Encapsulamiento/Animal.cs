using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo03_Encapsulamiento
{
    class Animal
    {
        private String a_nombre;
        private int a_edad;
        private string a_sexo;
        protected string raza;
        protected string duenyo;

        protected int edad
        {
            get
            {
                return a_edad;
            }
            set
            {
                if(value>0){
                    a_edad=value;
                }

            }
        }
        protected String sexo
        {
            get
            {
                return a_sexo;
            }
            set
            {
                if (value.Equals("HOMBRE") || value.Equals("MUJER"))
                    a_sexo=value;
 
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



        protected internal void dormir()
        {
            System.Windows.Forms.MessageBox.Show("Estoy durmiendo");
        }

        protected internal void jugar()
        {
            System.Windows.Forms.MessageBox.Show("Soy " + nombre + " y estoy jugando");
        }

        protected internal void aparear()
        {

        }
        protected internal void correr()
        {

        }
    }
}
