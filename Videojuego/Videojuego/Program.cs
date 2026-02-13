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

            Personaje personaje1 = new Personaje("Daniel", 88, 300, "Villano", "Lanzar cuchillas");

            personaje1.MostrarDatos();
            personaje1.Atacar();

            
        }
    }
}
