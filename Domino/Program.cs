using System;

namespace Domino
{
    class Domino
    {
        public int Espacio1;
        public int Espacio2;
        public Domino(int a, int b)
        {
            Espacio1 = a;
            Espacio2 = b;
        }
        public static Domino operator +(Domino x, Domino y)
        {
            int arriba = x.Espacio1+y.Espacio1;
            int abajo = x.Espacio2+y.Espacio2;
            return new Domino(arriba, abajo);
        }
        
        public override string ToString()
        {
            return String.Format("{0}/{1}", Espacio1, Espacio2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Domino ficha1 = new Domino(2,3);
            Domino ficha2 = new Domino(4,5);
            Domino c = ficha1+ficha2;
            //Me marca error al momento de imprimir, no se porque :c//
            Console.Writeline(ficha1);
            Console.Writeline(ficha2);
            Console.Writeline(c);

        }
    }
}
