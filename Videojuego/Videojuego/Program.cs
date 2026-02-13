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
            Arquero arquero1 = new Arquero("Elias", "Villano", 200, "Lanzar flechas de fuego", 80);
            Robot robot1 = new Robot("Elder", "Lanzar Misiles", "Acero", 400);


            arquero1.MostrarDatos();
            arquero1.Atacar();

            robot1.MostrarDatos();
            robot1.Atacar();
            robot1.Defenderse();

            Console.ReadKey();
            
        }
    }
}
