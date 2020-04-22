using System;
namespace MusicosAbstractos
{
    abstract class Musico
    {
        protected string nombre;
        protected string Afinar;
        protected string Toque;
        public Musico (string n)
        {
            nombre = n;
        } 
        public abstract void saluda();
        public abstract void Afina();
        public abstract void Tocar();
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
            Console.WriteLine("Hola soy El Baterista {0}, mi pila el la mejor, es una {1}",nombre, bateria);
        }
 public override void Afina()
        {
            Console.WriteLine("Probare mi bateria");
        }
        public override void Tocar()
        {
            Console.WriteLine("Algo sencillo para empezar");
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
            Console.WriteLine("Hola soy El bajista {0}, me gusta mucho mi bajo, es un {1}",nombre, bajo);
        }
        public override void Afina()
        {
            Console.WriteLine("Creo que afinare mi bajo ahora");
        }
         public override void Tocar()
        {
            Console.WriteLine("Tocare algo atrevido pero discreto");
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
            Console.WriteLine("Hola soy El Guitarrista {0},escucha esta de mi {1}",nombre, Guitarra);
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
            Baterista Kratos = new Baterista("Kratos", "tommy");
            Bajista Hall = new Bajista("Hall", "pilar ");
            Guitarrista Carlos= new Guitarrista("Carlos", "P34k ");
            Kratos.saluda();
            Kratos.Afina();
            Kratos.Tocar();
            Hall.saluda();
            Hall.Afina();
            Hall.Tocar();
            Carlos.saluda();
            Carlos.Afina();
            Carlos.Tocar();
        }
    }
}