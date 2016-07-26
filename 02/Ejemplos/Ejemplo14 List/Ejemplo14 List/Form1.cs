using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo14_List
{
    public partial class Form1 : Form
    {
        List<String> lista = new List<String>();  //List es una colección, List ya es un nombre que viene predefinido.
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            lista.Add(txt_valor.Text);
            lbl_agregar.Text = "Se agrego " + txt_valor.Text + " a la lista";
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            int tam = lista.Count;
       //     for (int i = 0; i < tam; i++)
        //    {
         //       Console.WriteLine(lista[i]);
          //  }

            foreach (String valor in lista)
            {
                Console.WriteLine(valor);
            }
        }

        private void btn_posicion_Click(object sender, EventArgs e)
        {
            lbl_posicion.Text = lista[Convert.ToInt16(txt_valor.Text)];
        }

        private void btn_valor_Click(object sender, EventArgs e)
        {
            lbl_valor.Text = Convert.ToString(lista.IndexOf(txt_valor.Text));
        }
    }
}
