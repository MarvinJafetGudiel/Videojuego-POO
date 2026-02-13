using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    internal class Arquero:Personaje
    {
        protected int VelocidadDisparo {get;set;}
        protected int Presicion { get;set;}

        public Arquero() { }

        public Arquero(string nombre, string tipo, int velocidadDisparo, string superPoder, int presicion )
        :base(nombre, 100, tipo, superPoder)
        {
            this.VelocidadDisparo = velocidadDisparo;
            this.Presicion = presicion;
        }

        public override void Atacar()
        {
            Console.WriteLine("el personaje {0} Comienza a atacar con su super poder: {1}, con una presicion de {2}", this.Nombre, this.SuperPoder, this.Presicion);
            Console.WriteLine("-----------------------------------------------------------------------------------");
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();

            Console.WriteLine("Velocidad de disparo: {0}", this.VelocidadDisparo);

            Console.WriteLine("Presicion: {0}", this.Presicion);

            Console.WriteLine("---------------------------------------------------------------------------------");
        }


    }
}
