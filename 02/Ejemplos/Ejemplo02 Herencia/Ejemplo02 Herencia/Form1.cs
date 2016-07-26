using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo02_Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_crear_objeto_Click(object sender, EventArgs e)
        {
         /*   if (cmb_animal.SelectedIndex==1)
            {
                Gato g = new Gato(txt_nombre.Text,Convert.ToInt32(txt_edad.Text),txt_sexo.Text);
                g.aparear();
                g.correr();
                g.dormir();
                g.maullar();
                g.jugar();

            }
            else {
                Perro p = new Perro(txt_nombre.Text, Convert.ToInt32(txt_edad.Text), txt_sexo.Text);
                p.aparear();
                p.correr();
                p.dormir();
                p.ladrar();
                p.jugar();
            }*/
            String animal_seleccionado = (String)cmb_animal.SelectedItem;
            switch ( animal_seleccionado){
                case "Perro":case "PERRO":
                    Perro p = new Perro(txt_nombre.Text, Convert.ToInt32(txt_edad.Text), txt_sexo.Text);
                    p.aparear();
                    p.correr();
                    p.dormir();
                    p.ladrar();
                    p.jugar();
                    break;
                case "Gato":
                    Gato g = new Gato(txt_nombre.Text, Convert.ToInt32(txt_edad.Text), txt_sexo.Text);
                    g.aparear();
                    g.correr();
                    g.dormir();
                    g.maullar();
                    g.jugar();
                    break;
                default:
                    break;
                       
            }



        }

    
    }
}
