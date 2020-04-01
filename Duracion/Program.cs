using System;
namespace Duracion
{
    class Duracion
    {
        public int Horas;
        public int Minutos;
        public int Segundos;
        public Duracion(int a, int b, int c)
        {
            Horas = a;
            Minutos = b;
            Segundos = c;
        }
        public Duracion()
        {
        }
       
        public void Conversion()
        {
            int Hora = Horas * 60;
            Console.WriteLine("Horas a Minutos: ");
            Console.WriteLine("{0} Minutos", Hora);
            int Minuto = Minutos * 60;
            Console.WriteLine("Horas a Segundos: ");
            int Segundos = Horas * 3600;
            Console.WriteLine("{0} Segundos", Segundos);
        }
        public static int operator + (Duracion Tmp2, Duracion Tmp3)
        {
            return ((Tmp2.Horas + Tmp3.Horas) * 3600) + ((Tmp2.Minutos + Tmp3.Minutos) *60) + ((Tmp2.Segundos + Tmp3.Segundos));
        }
         public void Print()
        {
            Console.WriteLine("{0}: {1}: {2}", Horas, Minutos, Segundos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duracion 1: ");
            Duracion Tmp0 = new Duracion(3, 50, 32);
            Tmp0.Print();
            Tmp0.Conversion();
            Console.WriteLine("Duracion 2: ");
            Duracion Tmp1 = new Duracion(2, 24, 18);
            Tmp1.Print();
            Tmp1.Conversion();
            Console.WriteLine("La suma de las 2 Duraciones en segundos es: " + (Tmp0 + Tmp1));
        }
    }
}