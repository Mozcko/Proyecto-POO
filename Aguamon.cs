using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    class Aguamon : Roquemon
    {
        public Aguamon(string nombre, string tipo, int vida, int ataque, int defensa, int velocidad, int critico) : base(nombre, tipo, vida, ataque, defensa, velocidad, critico)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.vida = vida;
            this.ataque = ataque;
            this.defensa = defensa;
            this.velocidad = velocidad;
            this.critico = critico;
        }
        public override void ataqueEspecial()
        {
            //se aumenta la velocidad en 100 en este turno y despues se ataca
            this.velocidad += 100;
        }
    }
}
