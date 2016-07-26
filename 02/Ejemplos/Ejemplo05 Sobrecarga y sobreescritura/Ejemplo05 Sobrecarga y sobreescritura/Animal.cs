using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo05_Sobrecarga_y_sobreescritura
{
    class Animal
    {
        protected String nombre;
        protected int edad;


        public Animal(int e, string n)
        {
            nombre = n;
            edad = e;
        }


    

        public Animal(String nom):this(0,nom)
        {
   
           
        }

        public int pedad
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public void comer()
        {
            throw new System.NotImplementedException();
        }

        private void dormir()
        {
            throw new System.NotImplementedException();
        }

        public virtual void hablar()
        {
            throw new System.NotImplementedException();
        }
    }
}
