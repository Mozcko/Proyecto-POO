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
    public partial class Form3 : Form
    {
        Form1 principal;
        Form2 seleccion;
        InputBox inputBox;
        string nombre_jugador1, nombre_jugador2;
        Roquemon roquemon1, roquemon2;
        string ataque1_roquemon1, ataque2_roquemon1, ataque1_roquemon2, ataque2_roquemon2;
        bool turno;
        int turnos_ch_r1, turnos_ch_r2;

        public Form3(Form2 seleccion,Form1 principal ,InputBox inputBox)
        {
            InitializeComponent();

            this.principal = principal;
            this.seleccion = seleccion;
            this.inputBox = inputBox;
            this.nombre_jugador1 = inputBox.Nombre_jugador_1;
            this.nombre_jugador2 = inputBox.Nombre_jugador_2;
            this.roquemon1 = seleccion.Roquemon1;
            this.roquemon2 = seleccion.Roquemon2;
            this.turno = true;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            llenarCampos();
        }
        public void llenarCampos()
        {
            switch (roquemon1.tipo)
            {
                case "agua":
                    ataque1_roquemon1 = "Torrente";
                    ataque2_roquemon1 = "Ataque Rapido";
                    break;
                case "planta":
                    ataque1_roquemon1 = "Latigo";
                    ataque2_roquemon1 = "Fotosintesis";
                    break;
                case "fuego":
                    ataque1_roquemon1 = "Flama";
                    ataque2_roquemon1 = "Flama";
                    break;
                default:
                    ataque1_roquemon1 = "Placage";
                    ataque2_roquemon1 = "Ataque Especial";
                    break;
            }
            switch (roquemon2.tipo)
            {
                case "agua":
                    ataque1_roquemon2 = "Torrente";
                    ataque2_roquemon2 = "Ataque Rapido";
                    break;
                case "planta":
                    ataque1_roquemon2 = "Latigo";
                    ataque2_roquemon2 = "Fotosintesis";
                    break;
                case "fuego":
                    ataque1_roquemon2 = "Flama";
                    ataque2_roquemon2 = "Flama";
                    break;
                default:
                    ataque1_roquemon2 = "Placage";
                    ataque2_roquemon2 = "Ataque Especial";
                    break;
            }

            Ataque1.Text = ataque1_roquemon1;
            Ataque2.Text = ataque2_roquemon1;
            label1.Text = $"Turno de {nombre_jugador1}";
            label2.Text = $"Roquemon: {roquemon1.nombre}";

        }
        
        public void cambiarTurno()
        {
            if (turno)
            {
                Ataque1.Text = ataque1_roquemon2;
                Ataque2.Text = ataque2_roquemon2;
                label1.Text = $"Turno de {nombre_jugador2}";
                label2.Text = $"Roquemon: {roquemon2.nombre}";
                turnos_ch_r1++;
                turno = false;
            }
            else
            {
                Ataque1.Text = ataque1_roquemon1;
                Ataque2.Text = ataque2_roquemon1;
                label1.Text = $"Turno de {nombre_jugador1}";
                label2.Text = $"Roquemon: {roquemon1.nombre}";
                turnos_ch_r2++;
                turno = true;
            }

        }

        public int calcularDano()
        {
            
            
            return 5;
        }

        private void Ataque1_Click(object sender, EventArgs e)
        {
            if (turno)
            {

            }
            else
            {
                turnos_ch_r1 = 0;
            }
            cambiarTurno();
        }

        private void Ataque2_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                
            }
            else
            {
                turnos_ch_r2 = 0;
            }
            cambiarTurno();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Seguro que quieres salir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
