﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo01_Abstraccion
{
    class Perro
    {
        public String nombre;
        public int edad;
        public string sexo;
        public String raza;
        public String duenyo;



        public Perro(String nombre, int edad, String sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;

        }
        public void ladrar()
        {

            System.Windows.Forms.MessageBox.Show("Estoy ladrando");
        }
        public void dormir()
        {
            System.Windows.Forms.MessageBox.Show("Estoy durmiendo");
        }
        public void jugar()
        {
            System.Windows.Forms.MessageBox.Show("Soy " + nombre + " y estoy jugando");
        }
        public void correr() { }
        public void aparear() { }




    }
}
