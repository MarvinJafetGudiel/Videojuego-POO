using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    internal class Personaje
    {
        protected int idPersonaje = 0;

        protected int ID {  get; set; }

        protected string Nombre {  get; set; }

        protected int Vida {  get; set; }

        protected int PoderAtaque { get; set; }

        protected string Tipo {  get; set; }

        protected string SuperPoder {  get; set; }

        public Personaje() { }

        public Personaje(string nombre, int vida, int poderAtaque, string tipo, string superPoder)
        {
            this.ID = CrearID();
            this.Nombre = nombre;
            this.Vida = vida;
            this.PoderAtaque = poderAtaque;
            this.Tipo = tipo;
            this.SuperPoder = superPoder;
        }

        public int CrearID()
        {
            return ++idPersonaje;
        }

        public virtual void Atacar()
        {
            Console.WriteLine("el personaje {0} Comienza a atacar con su super poder: {1} causando {2} de daño", this.Nombre,this.SuperPoder, this.PoderAtaque);
            Console.WriteLine("-----------------------------------------------------------------------------------");
        }

        public void MostrarDatos()
        {
            Console.WriteLine("ID: {0}", this.ID);

            Console.WriteLine("Nombre: {0}", this.Nombre);

            Console.WriteLine("Vida: {0}", this.Vida);

            Console.WriteLine("Poder de ataque: {0}", this.PoderAtaque);

            Console.WriteLine("Tipo: {0}", this.Tipo);

            Console.WriteLine("Super poder: {0}", this.SuperPoder);

            Console.WriteLine("---------------------------------------------------------------------------------");
        }


    }
}
