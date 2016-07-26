using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo13_List
{
    public partial class Form1 : Form
    {
        List<String> lista = new List<String>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            lista.Add(txt_valor.Text);
        }

   
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            //long tam = lista.LongCount();
            //for (int i = 0; i < tam; i++)
            //{
            //    Console.WriteLine(lista.ToString());

            //}

            foreach (String valor in lista)
            {
                Console.WriteLine(valor);

            }


        }

        private void btn_posicion_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lista.IndexOf(txt_valor.Text));
        }

        private void btn_valor_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lista[0]);
            //lista.FindIndex(
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
