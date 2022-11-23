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
        public int critico;

        public Roquemon(string nombre, string tipo, int vida, int ataque, int defensa, int velocidad, int critico)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.vida = vida;
            this.ataque = ataque;
            this.defensa = defensa;
            this.velocidad = velocidad;
            this.critico = critico;
        }

        //cambiar variables a tipo int para poder usar la funcion correctamente
        //el hacer esto permitira usar los valores obtenidos

        public int placaje()
        {
            //ataca en este turno con un bono de 5 de ataque
            //suple la función de Torrente, Flama  y Latigo
            //es cuando el Roquemon ataca
            return ataque + 5;
        }

        public virtual void ataqueEspecial()
        {

        }

        public bool comprobarVida()
        {
            if(this.vida <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
