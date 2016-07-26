using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo10_Pila_entera
{
    public partial class Form1 : Form
    {
        Pila p = null;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (p==null)
                p=new Pila(20);
            p.agregar(Convert.ToInt32(txt_valor.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(p.sacar()));
        }
    }
}
