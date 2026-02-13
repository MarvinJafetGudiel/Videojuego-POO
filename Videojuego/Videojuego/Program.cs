using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arquero arquero1 = new Arquero("Elias", "Aliado", 200, "Lanzar flechas de fuego", 80);


            arquero1.MostrarDatos();
            arquero1.Atacar();

            Console.ReadKey();
            
        }
    }
}
