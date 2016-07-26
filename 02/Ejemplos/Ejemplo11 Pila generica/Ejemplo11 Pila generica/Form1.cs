using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo11_Pila_generica
{
    public partial class Form1 : Form
    {
        Pila<int> p = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p= new Pila<int>();

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            p.agregar(Convert.ToInt16(txt_valor.Text));
        }
    }
}
