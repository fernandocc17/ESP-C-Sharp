using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo02_Los_3_basicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_pasar_Click(object sender, EventArgs e)
        {
            lbl_texto.Text = txt_palabra.Text;
        }
    }
}
