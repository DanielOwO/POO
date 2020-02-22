using System;

namespace Pelicula
{
    class Pelicula
    {
        private string titulo;
        private Int16 año;
        public string pais;
        public string director;

        public void setTitulo(string t)
        {
            titulo = t;


        }

        public void setAño(Int16 a)
        {
            año = a;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            Pelicula p2 = new Pelicula();
            p1.titulo = "Luz de luna";
            p2.titulo = "Birdman";
            p1.args = 2016;
            p2.año = 2014;
            p1.pais = "Estados Unidos";
            p1.director = "Barry Jenkins";
            p2.pais = "Estados Unidos";
            p2.director = "Alejandro Gonzalez Iñarritu";

            

        }
    }
}
