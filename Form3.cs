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
        Roquemon roquemon1, roquemon2, roquemon1_base, roquemon2_base;
        Random random;
        string nombre_jugador1, nombre_jugador2;
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
            this.roquemon1_base = seleccion.Roquemon1;
            this.roquemon2_base = seleccion.Roquemon2;
            this.turno = true;
            random = new Random();
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
                    ataque2_roquemon1 = "Furia";
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
                    ataque2_roquemon2 = "Furia";
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
                if (turnos_ch_r1 < 3)
                {
                    turnos_ch_r1++;
                }
                turno = false;
            }
            else
            {
                Ataque1.Text = ataque1_roquemon1;
                Ataque2.Text = ataque2_roquemon1;
                label1.Text = $"Turno de {nombre_jugador1}";
                label2.Text = $"Roquemon: {roquemon1.nombre}";
                if(turnos_ch_r2 < 3)
                {
                    turnos_ch_r2++;
                }
                calcularDano();
                turno = true;
            }
        }

        private string superEfectivo()
        {
            if (roquemon1.tipo == "agua" && roquemon2.tipo == "fuego")
            {
                return "roquemon1";
            }
            else if (roquemon1.tipo == "fuego" && roquemon2.tipo == "planta")
            {
                return "roquemon1";
            }
            else if (roquemon1.tipo == "planta" && roquemon2.tipo == "agua")
            {
                return "roquemon1";
            }
            else if (roquemon1.tipo == "fuego" && roquemon2.tipo == "agua")
            {
                return "roquemon2";
            }
            else if (roquemon1.tipo == "planta" && roquemon2.tipo == "fuego")
            {
                return "roquemon2";
            }
            else if (roquemon1.tipo == "agua" && roquemon2.tipo == "planta")
            {
                return "roquemon2";
            }
            else
            {
                return null;
            }
        }

        public void calcularDano()
        {
            int velocidad_roquemon1, velocidad_roquemon2, ataque_efectivo_roquemon1, ataque_efectivo_roquemon2;
            float dano_roquemon1, dano_roquemon2;
            bool critico_roquemon1, critico_roquemon2;


            ataque_efectivo_roquemon1 = roquemon1.ataque + random.Next(-7,7);
            ataque_efectivo_roquemon2 = roquemon2.ataque + random.Next(-7, 7);

            dano_roquemon1 = ataque_efectivo_roquemon1 - roquemon2.defensa;
            dano_roquemon2 = ataque_efectivo_roquemon2 - roquemon1.defensa;

            velocidad_roquemon1 = roquemon1.velocidad + random.Next(-10, 10);
            velocidad_roquemon2 = roquemon2.velocidad + random.Next(-10, 10);

            critico_roquemon1 = random.Next(0,100) >= roquemon1.critico;
            critico_roquemon2 = random.Next(0, 100) >= roquemon2.critico;

            //probabilidades de critico y ataques superefectivos
            if (critico_roquemon1)
            {
                dano_roquemon1 *= 2;
                if(superEfectivo() == "roquemon1")
                {
                    dano_roquemon1 *= 1.5f;
                    MessageBox.Show($"El ataque fue super Efectivo e hizo {dano_roquemon1} de daño");
                }
            }
            else if (critico_roquemon2)
            {
                dano_roquemon2 *= 2;
                if(superEfectivo() == "roquemon2")
                {
                    dano_roquemon2 *= 1.5f;
                    MessageBox.Show($"El ataque fue super Efectivo e hizo {dano_roquemon2} de daño");
                }
            }

            if (velocidad_roquemon1 > velocidad_roquemon2)
            {
                roquemon2.vida -= (int)dano_roquemon1;
                if (!roquemon2.comprobarVida())
                {
                    MessageBox.Show($"{nombre_jugador1} Gano con su {roquemon1.nombre}!!!");
                }
                roquemon1.vida -= (int)dano_roquemon2;
                if (!roquemon1.comprobarVida())
                {
                    MessageBox.Show($"{nombre_jugador2} Gano con su {roquemon2.nombre}!!!");
                }
            }
            else if (velocidad_roquemon1 < velocidad_roquemon2)
            {
                roquemon1.vida -= (int)dano_roquemon2;
                if (!roquemon1.comprobarVida())
                {
                    MessageBox.Show($"{nombre_jugador2} Gano con su {roquemon2.nombre}!!!");
                }
                roquemon2.vida -= (int)dano_roquemon1;
                if (!roquemon2.comprobarVida())
                {
                    MessageBox.Show($"{nombre_jugador1} Gano con su {roquemon1.nombre}!!!");
                }
            }
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
            var result = MessageBox.Show("Seguro que quieres salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
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
