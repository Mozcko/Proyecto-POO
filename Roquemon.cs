using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    class Roquemon
    {
        public string nombre;
        public string tipo;
        public int vida;
        public int ataque;
        public int defensa;
        public int velocidad;
        public float critico;

        public Roquemon(string nombre, string tipo, int vida, int ataque, int defensa, int velocidad, float critico)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.vida = vida;
            this.ataque = ataque;
            this.defensa = defensa;
            this.velocidad = velocidad;
            this.critico = critico;
        }

        public void bonoDano ()
        {
            //ataca en este turno con un bono de 5 de ataque
            //suple la función de Torrente, Flama  y Latigo
        }
/* A new line. */

        public void placaje()
        {
            //es cuando el Roquemon ataca, independientemente de la habilidad que haya escogido 
        }
    }
}
