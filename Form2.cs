﻿using System;
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
    public partial class Form2 : Form
    {
        List<Roquemon> roquemons;
        int players = 0;
        
        public Form2()
        {
            InitializeComponent();
            roquemons = new List<Roquemon>();
            leerArchivo();
            
        }

        /// It reads a .csv file and creates a Roquemon for each line in the file
        public void leerArchivo()
        {
            StreamReader reader = new StreamReader("datosRoquemon.csv");

            var aguamon = reader.ReadLine().Split(',');
            Aguamon ag = new Aguamon(aguamon[0], aguamon[1], int.Parse(aguamon[2]), int.Parse(aguamon[3]), int.Parse(aguamon[4]), int.Parse(aguamon[5]), float.Parse(aguamon[6]));

            var plantamon = reader.ReadLine().Split(',');
            Plantamon pl = new Plantamon(plantamon[0], plantamon[1], int.Parse(plantamon[2]), int.Parse(plantamon[3]), int.Parse(plantamon[4]), int.Parse(plantamon[5]), float.Parse(plantamon[6]));

            var fuegomon = reader.ReadLine().Split(',');
            Fuegomon fg = new Fuegomon(fuegomon[0], fuegomon[1], int.Parse(fuegomon[2]), int.Parse(fuegomon[3]), int.Parse(fuegomon[4]), int.Parse(fuegomon[5]), float.Parse(fuegomon[6]));

            roquemons.Add(ag);
            roquemons.Add(pl);
            roquemons.Add(fg);

            reader.Close();
        }
        public void apagarBotones()
        {
            button1.Visible = false;
            button1.Enabled = false;
            button2.Visible = false;
            button2.Enabled = false;
            button3.Visible = false;
            button3.Enabled = false;
            LabelMenu.Visible = false;
        }
        //aguamon
        private void button1_Click(object sender, EventArgs e)
        {
            if (players == 0)
            {
                Roquemon roquemon1 = roquemons[0];
                MessageBox.Show($"el {LabelMenu.Text.Substring(0, 8)} escogio a :{roquemon1.nombre}");
                players++;
            }
            else
            {
                Roquemon roquemon2 = roquemons[0];
                MessageBox.Show($"el {LabelMenu.Text.Substring(0, 8)} escogio a :{roquemon2.nombre}");
                apagarBotones();
            }
            LabelMenu.Text = "Jugador2: escoje tu Roquemon";
            button1.Enabled = false;
        }

        //fuegomon
        private void button2_Click(object sender, EventArgs e)
        {
            if (players == 0)
            {
                Roquemon roquemon1 = roquemons[1];
                MessageBox.Show($"el {LabelMenu.Text.Substring(0, 8)} escogio a :{roquemon1.nombre}");
                players++;
            }
            else
            {
                Roquemon roquemon2 = roquemons[1];
                MessageBox.Show($"el {LabelMenu.Text.Substring(0, 8)} escogio a :{roquemon2.nombre}");
                apagarBotones();
            }
            LabelMenu.Text = "Jugador2: escoje tu Roquemon";
            button2.Enabled = false;
        }

        //plantamon
        private void button3_Click(object sender, EventArgs e)
        {
            if (players == 0)
            {
                Roquemon roquemon1 = roquemons[2];
                MessageBox.Show($"el {LabelMenu.Text.Substring(0, 8)} escogio a :{roquemon1.nombre}");
                players++;
            }
            else
            {
                Roquemon roquemon2 = roquemons[2];
                MessageBox.Show($"el {LabelMenu.Text.Substring(0, 8)} escogio a :{roquemon2.nombre}");
                apagarBotones();
            }
            LabelMenu.Text = "Jugador2: escoje tu Roquemon";
            button3.Enabled = false;
        }
    }
}
