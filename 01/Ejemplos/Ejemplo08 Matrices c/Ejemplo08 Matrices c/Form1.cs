using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo08_Matrices_c
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }


        public void cambiaEstado(Boolean buscar,Boolean crear)
        {
            txt_columnas_buscar.Enabled = buscar;
            txt_filas_buscar.Enabled = buscar;
            txt_agregar.Enabled = buscar;
            btn_agregar.Enabled = buscar;
            btn_buscar.Enabled = buscar;

            txt_columnas_crear.Enabled = crear;
            txt_filas_crear.Enabled = crear;
            btn_crear.Enabled = crear;
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            cambiaEstado(true, false);
            Arreglo a = new Arreglo(Convert.ToInt32(txt_filas_crear.Text),
                                    Convert.ToInt32(txt_columnas_crear.Text));
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cambiaEstado(false, true);
        }
    }
}
