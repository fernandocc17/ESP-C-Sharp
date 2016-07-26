using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo11_Pila_entera
{
    public partial class Form1 : Form
    {
        Pila p = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_push_Click(object sender, EventArgs e)
        {
            p.push(Convert.ToInt16(txt_valor.Text));
        }

        private void btn_pop_Click(object sender, EventArgs e)
        {
            MessageBox.Show(   Convert.ToString(  p.pop() ) );
        }
    }
}
