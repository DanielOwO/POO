using System;
using System.Collections.Generic;
namespace Musicos
{
    class Musico
    {
        protected string nombre;
        protected string Afinar;
        protected string Toque;
        public Musico (string n)
        {
            nombre = n;
        } 
        public virtual void saluda()
        {
            Console.WriteLine("Hola soy {0}",nombre);
        }
        public virtual void Afina()
        {
            Console.WriteLine("dejen afino ");
        }
        public virtual void Tocar()
        {
            Console.WriteLine("Vamos a empezar a tocar");
        }
    }
    class Baterista:Musico
    {
        protected string bateria;
        public Baterista(string nombre, string bateria):base(nombre)
        {
            this.bateria= bateria; 
        }
         public override void saluda()
        {
            Console.WriteLine("Hola soy El Baterista {0}, mi bateria el la mejor, es una {1}",nombre, bateria);
        }
         public override void Afina()
        {
            Console.WriteLine("voy a calar la bateria");
        }
        public override void Tocar()
        {
            Console.WriteLine("Empecemos con mi solo");
        }
    }
    class Bajista:Musico
    {
        protected string bajo;
        public Bajista(string nombre, string bajo):base(nombre)
        {
            this.bajo= bajo; 
        }
         public override void saluda()
        {
            Console.WriteLine("Hola soy El bajista {0}, toco bien perro mi bajo, es un {1}",nombre, bajo);
        }
        public override void Afina()
        {
            Console.WriteLine("voy a afinar mi bajo");
        }
         public override void Tocar()
        {
            Console.WriteLine("Empecemos con mi solo");
        }
    }
    class Guitarrista:Musico
    {
        protected string Guitarra;
        public Guitarrista(string nombre, string Guitarra):base(nombre)
        {
            this.Guitarra= Guitarra; 
        }
         public override void saluda()
        {
            Console.WriteLine("Hola soy El Guitarrista {0},escucha este solo de mi {1}",nombre, Guitarra);
        }
        public override void Afina()
        {
            Console.WriteLine("voy a afinar mi");
        }
         public override void Tocar()
        {
            Console.WriteLine("Empecemos con mi solo");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Musico Marcial = new Musico(" Marcial ");
           Marcial.saluda();
           Marcial.Afina();
           Marcial.Tocar();
            Baterista Javier = new Baterista("Javier", "tommy");
            Bajista Tom = new Bajista("Tom", "pilar ");
            Guitarrista Donald= new Guitarrista("Donald", "P34k ");
            Javier.saluda();
            Javier.Afina();
            Javier.Tocar();
            Tom.saluda();
            Tom.Afina();
            Tom.Tocar();
            Donald.saluda();
            Donald.Afina();
            Donald.Tocar();
        List<Musico> Musicos = new List<Musico>();
            Musicos.Add(Marcial);
            Musicos.Add(Javier);
            Musicos.Add(Tom);
            Musicos.Add(Donald);
        foreach(Musico n in Musicos)
        {
            n.saluda();
        }
        }
    }
}