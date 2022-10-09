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

        public void bonoDano ()
        {
            //ataca en este turno con un bono de 5 de ataque
            //suple la funcion de Torrente, Flama  y Latigo
        }

        public void placaje()
        {
            //es cuando el roquemon ataca, independientemente de la habilidad que haya escogido 
        }
    }
}
