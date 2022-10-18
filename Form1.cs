using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_POO
{
    public partial class Form1 : Form
    {
        Form2 formulario2;

        public Form1()
        {
            InitializeComponent();
            formulario2 = new Form2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formulario2.Show();
            this.Hide();
        }
    }
}
