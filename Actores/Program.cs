using System;
using System.Collections.Generic;

namespace Actores
{
    class Pelicula
    {
         public List <string> Famosos = new List <string>();
         public void AgregarActor(Actor Pelicula)
         {
             Famosos.Add(Actor);
         }
         public void ImprimeActores()
         {
             Console.WriteLine(Actor);
            foreach(Famosos n in Actor)
            {
                Console.WriteLine();
            }
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
