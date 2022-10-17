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
        List<Roquemon> roquemons;
        public Roquemon r1 = new Roquemon(); //roquemon del primer jugador
        public Roquemon r2 = new Roquemon(); //roquemon del segundo jugador
        public Form1()
        {
            InitializeComponent();
            roquemons = new List<Roquemon>();
        }

        /// It reads a .csv file and creates a Roquemon object for each line in the file
        public void leerArchivo()
        {
            StreamReader reader = new StreamReader('datosRoquemon.csv');
            while (!reader.EndOfStream())
            {
                var linea = reader.ReadLine().Split(',');
                Roquemon ro = new Roquemon(linea[0], linea[1], linea[2], linea[3], linea[4], linea[5], linea[6]);
                roquemons.Add(ro);
            }
            reader.Close();
        }

        /* A method that takes a Roquemon object as a parameter and assigns it the values of the
        Roquemon object that has the same name as the parameter. */
        public void asignarRoquemon(Roquemon ro)
        {
            foreach (var roquemon in roquemons)
            {
                if (ro.nombre == roquemon.nombre)
                {
                    // se le asignan los valores del roquemon correspondiente
                    ro.tipo = roquemon.tipo;
                    ro.vida = roquemon.vida;
                    ro.ataque = roquemon.ataque;
                    ro.defensa = roquemon.defensa;
                    ro.velocidad = roquemon.velocidad;
                    ro.critico = roquemon.critico;
                }
                else 
                {
                    //da error
                }
            }
        }
    }
}
