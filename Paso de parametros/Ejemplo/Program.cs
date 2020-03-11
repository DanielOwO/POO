using System;

namespace Ejemplo
{
    class Duplicador
    {
        public void duplica(int n)
        {
            n = n*2;
        }
        public void duplica_ref(ref int n)
        {
            n = n*2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duplicador d = new Duplicador();
            d.duplica(1);
            int x = 2;
            d.duplica(x);
            Console.WriteLine(x);
            d.duplica_ref(x);
            Console.WriteLine(x);
        }
    }
}
