using System;

namespace proyectoVectorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 5;
            while (op == 5)
            {
                Console.WriteLine("Elija una opcion" +
                    "\n1.Producto punto" +
                    "\n2.Producto vectorial" +
                    "\n3.Volumen del Paralelepipledo" +
                    "\n4.Ecuacion Parametrica y Simetrica" +
                    "\n5.Ecuacion Canonica" +
                    "\n6.Salir");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        PP();
                        break;
                    case 2:
                        Console.Clear();
                        PC();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        EP();
                        break;
                    case 5:
                        Console.Clear();
                        EC();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Buen dia");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error de captura");
                        break;
                }
            }
        }

        static void PP()
        {
            int i = 0, j = 0, k = 0, pp = 0;
            int[] ie;
            int[] je;
            int[] ke;
            ie = new int[2];
            je = new int[2];
            ke = new int[2];
            for (int r = 1; r <= 2; r++)
            {
                Console.WriteLine("i{0}=", r);
                ie[r] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("j{0}=", r);
                je[r] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("k{0}=", r);
                ke[r] = Convert.ToInt32(Console.ReadLine());
            }
            i = ie[1] * ie[2];
            j = je[1] * je[2];
            k = ke[1] * ke[2];
            pp = i + j + k;
            Console.WriteLine("Producto punto={0}", pp);
        }

        static void PC()
        {
            int i = 0, j = 0, k = 0;
            int[] ie;
            int[] je;
            int[] ke;
            ie = new int[2];
            je = new int[2];
            ke = new int[2];
            string sn = "-", kn = "+";
            for (int r = 1; r <= 2; r++)
            {
                Console.WriteLine("i{0}=", r);
                ie[r] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("j{0}=", r);
                je[r] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("k{0}=", r);
                ke[r] = Convert.ToInt32(Console.ReadLine());
            }
            i = ((je[1] * ke[2]) - (je[2] * ke[1]));
            j = ((ie[1] * ke[2]) - (ie[2] * ke[1]));
            k = ((ie[1] * je[2]) - (ie[2] * je[1]));
            if (j <= 0)
            {
                j = j * (-1);
                sn = "+";
            }
            if (k <= 0)
            {
                kn = "-";
            }
            Console.WriteLine("Producto cruz" +
                "\n{0}{1}{2}{3}{4}", i, sn, j, kn, k);
        }

        static void EP()
        {
            int[] punto = new int[3];
            int[] vector = new int[3];

            Console.WriteLine("Cual es tu punto (x)?");
            punto[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es tu punto (y)?");
            punto[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es tu punto (z)?");
            punto[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es tu vector (x)?");
            vector[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es tu vector (y)?");
            vector[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es tu vector (z)?");
            vector[2] = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Ecuacion Parametrica");
            if ((vector[0]) > 0)
            {
                Console.WriteLine("X = {0}+{1}t", punto[0], vector[0]);
            }
            else
            {
                Console.WriteLine("X = {0}{1}t", punto[0], vector[0]);
            }

            if ((vector[1]) > 0)
            {
                Console.WriteLine("X = {0}+{1}t", punto[1], vector[1]);
            }
            else
            {
                Console.WriteLine("X = {0}{1}t", punto[1], vector[1]);
            }

            if ((vector[2]) > 0)
            {
                Console.WriteLine("X = {0}+{1}t", punto[2], vector[2]);
            }
            else
            {
                Console.WriteLine("X = {0}{1}t", punto[2], vector[2]);
            }

            Console.WriteLine("\nEcuacion Simetrica");
            Console.WriteLine("X = {0}", punto[0]);
            Console.WriteLine("Y = {0}", punto[1]);
            Console.WriteLine("Z = {0}", punto[2]);
        }

        static void EC()
        {
            int[] o = new int[3];
            int[] p = new int[3];
            int[] q = new int[3];
            int[] n = new int[3];
            int[] u = new int[3];
            int[] v = new int[3];

            Console.WriteLine("Cual es tu punto O (x)?");
            o[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es tu punto O (y)?");
            o[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es tu punto O (z)?");
            o[2] = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Cual es tu punto P (x)?");
            p[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es tu punto P (y)?");
            p[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es tu punto P (z)?");
            p[2] = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Cual es tu punto Q (x)?");
            q[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es tu punto Q (y)?");
            q[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es tu punto Q (z)?");
            q[2] = int.Parse(Console.ReadLine());

            
            Console.Clear();

            for(int x=0;x<=2;x++)
            {
                u[x] = (p[x]-o[x]);
            }

            for(int x=0;x<=2;x++)
            {
                v[x] = (q[x]-o[x]);
            }

            n = matrix(u,v);

            Console.WriteLine("Ecuacion normal = {0},{1},{2}", n[0],n[1],n[2]);
        }

        static int[] matrix(int[] u, int[] v)
        {
            int[] n = new int[3];

            n[0] = (u[1]*v[2])+(-(u[2]*v[1]));
            n[1] = (-(u[0]*v[2])+(-(u[2]*v[0])));
            n[2] = (u[0]*v[1])+(-(u[1]*v[0]));

            return n;
        }
    }
}

