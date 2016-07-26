using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Ejemplo12_Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_escribir_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"personas.csv",true);
            sw.WriteLine(txt_nombre.Text + ","+ txt_edad.Text);
            sw.Close();
        }

        private void btn_leer_Click(object sender, EventArgs e)
        {
            StreamReader lector = new StreamReader(@"personas.csv");
            while (!lector.EndOfStream)
            {
                Console.WriteLine(lector.ReadLine());

            }



        }
    }
}
