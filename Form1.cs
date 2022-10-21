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
using Microsoft.visualBasic;

namespace Proyecto_POO
{
    public partial class Form1 : Form
    {
        Form2 seleccion;
        string nombre1, nombre2;

        public Form1()
        {
            InitializeComponent();
            seleccion = new Form2(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nombre1 = pedir_nombres("jugador 1");
            nombre2 = pedir_nombres("jugador 1");
            seleccion.Show();
            this.Hide();
        }

        private string pedir_nombres(string Jugador)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("prompt", $"{jugador} ingresa tu nombre", "default", 0, 0);
            return "";
        }
    }
}
