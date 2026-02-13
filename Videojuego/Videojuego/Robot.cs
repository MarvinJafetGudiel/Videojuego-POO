using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    internal class Robot:Personaje
    {
        
        protected string TipoMaterial {  get; set; }

        protected int Resistencia {  get; set; }


        public Robot() { }

        public Robot(string nombre, string superPoder, string tipoMaterial, int resistencia) : base(nombre, 300, "Aliado", superPoder)
        {
            this.TipoMaterial = tipoMaterial;
            this.Resistencia = resistencia;
        }

        public override void Atacar()
        {
            Console.WriteLine("el personaje {0} Comienza a atacar con su super poder: {1}, con una resistencia de {2}", this.Nombre, this.SuperPoder, this.Resistencia);
            Console.WriteLine("-----------------------------------------------------------------------------------");
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();

            Console.WriteLine("Tipo de Material: {0}", this.TipoMaterial);

            Console.WriteLine("Resistencia: {0}", this.Resistencia);

            Console.WriteLine("---------------------------------------------------------------------------------");
        }


        public void Defenderse()
        {
            Console.WriteLine("El Robot {0} Sube la guardia para defenderse con su resistencia de: {1}, y su tipo de material de: {2}", this.Nombre, this.Resistencia, this.TipoMaterial);
            Console.WriteLine("-----------------------------------------------------------------------------------");
        }
    }
}
