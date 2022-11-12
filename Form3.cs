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
            llenarCampos();
        }

        private void llenarCampos()
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
        }
        
        public void cambiarTurno()
        {

        }
    }
}
