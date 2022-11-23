using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    class Plantamon : Roquemon 
    {
        public Plantamon(string nombre, string tipo, int vida, int ataque, int defensa, int velocidad, int critico) : base(nombre, tipo, vida, ataque, defensa, velocidad, critico)
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
            //atacara este turno y aumenta la defensa por 5 durante 3 turnos
        }
    }
}
