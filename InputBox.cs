using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class InputBox : Form
    {
        Form2 seleccion;
        public Form1 principal;

        string nombre_jugador_1, nombre_jugador_2;
        int player_count;
        bool filled;

        public InputBox(Form1 principal)
        {
            InitializeComponent();
            player_count++;
            this.principal = principal;
            seleccion = new Form2(principal, this);
        }

        public string Nombre_jugador_1 { get => nombre_jugador_1; set => nombre_jugador_1 = value; }
        public string Nombre_jugador_2 { get => nombre_jugador_2; set => nombre_jugador_2 = value; }
        public bool Filled { get => filled; set => filled = value; }

        public void Get_Players_name()
        {
            Label_player.Text = $"introduce tu nombre Jugador {player_count}";
            this.Show();
            filled = false;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (text_nombre.Text != "")
            {
                if (player_count == 1)
                {
                    nombre_jugador_1 = text_nombre.Text;
                    text_nombre.Clear();
                    player_count++;
                    Label_player.Text = $"introduce tu nombre Jugador {player_count}";
                    this.Hide();
                    this.Show();
                }
                else
                {
                    nombre_jugador_2 = text_nombre.Text;
                    text_nombre.Clear();
                    filled = true;
                    this.Hide();
                    principal.Hide();
                    seleccion.Show();
                }
            }
        }
    }
}
