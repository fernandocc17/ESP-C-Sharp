using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo01_Abstraccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_crear_objeto_Click(object sender, EventArgs e)
        {
            //Creamos una variable de referencia de tipo Perro
            Perro chata = null;
            //Instanciamos o creamos un objeto de tipo Perro, dandole los valores que solicita
            //el metodo constructor
            chata = new Perro(txt_nombre.Text, Convert.ToInt32(txt_edad.Text), txt_sexo.Text);
            //ejecutamos los metodos de Perro
            chata.dormir();
            chata.jugar();
            chata.ladrar();
            /*
            //creamos una variable de referencia de tipo Perro
            Perro Isis = null;
            //ejecutamos el metodo dormir de Isis pero esto nos arroja una excepcion
            //nullreference, debido a que Isis apunta a Null y no a un objeto
            Isis.dormir();
            */
        }
    }
}
