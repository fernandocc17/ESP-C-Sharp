using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ejemplo15_Split
{
    public partial class Form1 : Form
    {
        const int NOMBRE = 0;
        const int EDAD = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw=new StreamWriter(@"archivo.txt");
            sw.WriteLine(textBox1.Text+","+textBox2.Text);
            sw.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"archivo.txt");
            String linea = sr.ReadLine();
            sr.Close();
            String[] campos = linea.Split(',');
            

            Console.WriteLine(campos[NOMBRE]);
            Console.WriteLine(campos[EDAD]);

        }
    }
}
