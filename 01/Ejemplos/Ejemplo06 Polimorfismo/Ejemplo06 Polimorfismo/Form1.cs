using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo06_Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal a=null;
            Respiracion r = null;
            String opcion = (String) cmb_animal.SelectedItem;
           switch (opcion)
           {
               case "Gato": a = new Gato();
                   r = new Gato();
                   break;
               case "Perro":a=new Perro();
                   r = new Perro();
                   break;
           }
           a.hablar();
           r.respirar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
