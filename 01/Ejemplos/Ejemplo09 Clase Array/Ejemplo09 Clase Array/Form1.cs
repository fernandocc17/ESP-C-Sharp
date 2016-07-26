using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo09_Clase_Array
{
    public partial class Form1 : Form
    {
        const int LIMITE=3;
        int indice = 0;
        Array arreglo = Array.CreateInstance(typeof(String),LIMITE);
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if (! (indice ==LIMITE))
            {
                arreglo.SetValue(txt_valor.Text, indice++ );

            }
        
        }

        private void btn_ordenar_Click(object sender, EventArgs e)
        {
            Array.Sort(arreglo);
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LIMITE; i++)
            {
                Console.WriteLine(arreglo.GetValue(i));
            }

        }
    }
}
