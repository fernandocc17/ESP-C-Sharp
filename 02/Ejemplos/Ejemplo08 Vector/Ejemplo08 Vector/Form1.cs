using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo08_Vector
{
    public partial class Form1 : Form
    {
        const int TAM_APELLIDOS=3;
        String[] apellidos=new String [TAM_APELLIDOS];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            for(int indice=0;indice<i;indice++)

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            apellidos[i++] = txt_valor.Text;
           
        }
    }
}
