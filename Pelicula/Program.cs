using System;
using System.Collections.Generic;

namespace Pelicula
{
    class Persona
    {

        public string nombre;
        public List<Persona>personas;
        public Persona(string nombre)
        {
            this.nombre = nombre;
            personas = new List<Persona>();
        }
        public string getNombre()
        {
            return nombre;
        }
        public void AgregaNombre(Persona n)
        {
            personas.Add(n);
        }
        public void Print()
        {
            Console.WriteLine(nombre);
            foreach(Persona n in personas)
            {
                Console.WriteLine(n.getNombre());
            }
        }
    }
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
        
        public string getTitulo()
        {
            return titulo;
        }

        public Int16 getAño()
        {
            return año;
        }
        
        public Pelicula()
        {

        }
        public Pelicula(string titulo, Int16 año )
        {

        }
        public void imprime()
        {

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            Pelicula p2 = new Pelicula();
            /*p1.titulo = "Luz de luna";
            p2.titulo = "Birdman";
            p1.año = 2016;
            p2.año = 2014;
            p1.pais = "Estados Unidos";
            p1.director = "Barry Jenkins";
            p2.pais = "Estados Unidos";
            p2.director = "Alejandro Gonzalez Iñarritu";
            Console.WriteLine(p1.titulo + " " + p1.año);
            Console.WriteLine(p2.titulo + " " + p2.año); */

            p1.setTitulo("Luz de luna");
            p1.setAño(2016);
            Console.WriteLine("{0}({1})", p1.getTitulo(), p1.getAño());
            p2.setTitulo("Birdman");
            p2.setAño(2014);
            Console.WriteLine("{0}({1})", p2.getTitulo(), p2.getAño());
            Persona u1 = new Persona("Juan");
            Console.WriteLine(u1.getNombre());
            u1.AgregaNombre(new Persona("kim"));
            u1.AgregaNombre(new Persona("levi"));
            u1.Print();
        }
    }
}
