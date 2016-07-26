using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo07_Arreglos
{
    public partial class Form1 : Form
    {const int CLIENTE=5;
        String[] clientes=new String [CLIENTE];
        int pos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (pos < CLIENTE)
            {
                clientes[pos++]=txt_cadena.Text;
              
            }


        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pos; i++)
                MessageBox.Show(clientes[i]);
        }
    }
}
