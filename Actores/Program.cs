using System.Collections.Generic;

namespace Actores
{
    class Pelicula
    {
        private string actores;
        public AgregarActor(string actores)
        {
            this.actores = actores;
            Actor = new List<Actors>();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           Pelicula p1 = new Pelicula("La La Land", 2016);
           p1.AgregarActor(new Actor("Ryan Gosling", 1980));
           p1.AgregarActor(new Actor("Emma Stone", 1988));
           p1.AgregarActor(new Actor("Emma Stone", 1988));
           p1.ImprimeActores();
        }
    }
}
