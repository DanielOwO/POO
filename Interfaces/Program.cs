using System;
using System.Collections.Generic;
namespace figura
{
    interface IDibuja: IComparable
    {
        int x {get; set;}
        int y {get; set;}
        string color{get;set;}
        void dibuja();
        void printColor();
    }
    class Circulo : IDibuja
    {
        int x,y;
        string color;
        int IDibuja.x { get => x; set => x = value; }
        int IDibuja.y { get => y; set => y=value; }
        string IDibuja.color { get => color; set => color = value; }
        public Circulo(int x, int y, string c)
        {
            this.x=x;
            this.y=y;
            this.color =c;
        }
    public void dibuja()
    {
        Console.WriteLine("Se dibuja un circulo {0}", color);
    }
    public void printColor()
    {
        Console.WriteLine("El color es {0}", color);
    }
    public int CompareTo(object obj)
    {
        IDibuja otro = obj as IDibuja;
         return color.CompareTo(otro.color);
    }
    } 
    class Rect : IDibuja
    {
        int x,y;
        string color;
        public Rect(int x, int y, string c)
        {
            this.x=x;
            this.y=y;
            this.color=c;
        }
        int IDibuja.x { get => x; set => x = value; }
        int IDibuja.y { get => y; set => y=value; }
        string IDibuja.color { get => color; set => color = value; }
        public void dibuja()
        {
            Console.WriteLine("Se dibuja un rectangulo {0}", color);
        }
        public void printColor()
        {
            Console.WriteLine("El color es {0}", color);
        }
         public int CompareTo(object obj)
        {
            IDibuja otro = obj as IDibuja;
            return color.CompareTo(otro.color);
        }
        class Program
    {
        static void Main(string[] args)
        {
            List<IDibuja> figuras = new List<IDibuja>();
            figuras.Add(new Circulo(12,13,"verde")) ;
            figuras.Add(new Rect(12,13,"azul")) ;
            figuras.Add(new Rect(12,13,"rojo")) ;
            figuras.Add(new Circulo(12,13,"rojo")) ;
            foreach (var d in figuras)
            {
                d.dibuja();
            }   
            }
        }
}
}