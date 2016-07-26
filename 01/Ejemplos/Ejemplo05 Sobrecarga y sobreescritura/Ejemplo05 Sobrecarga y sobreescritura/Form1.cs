using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo05_Sobrecarga_y_sobreescritura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if("Gato".CompareTo(cmb_animal.SelectedItem)==0)
            {
                Gato g = new Gato();
                g.hablar();


            }
            if ("Perro".CompareTo(cmb_animal.SelectedItem) == 0)
            {
                Perro p = new Perro();
                p.hablar();
            }
        }
    }
}
