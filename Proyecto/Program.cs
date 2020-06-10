using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto
{
    //Declaracion de la clase producto
    class Producto:PrecioFecha
    {
        //Constructor
        public Producto(int yy, int mm, int dd, int yyf, int mmf, int ddf, int valor, string c, string d, int l):base(yy, mm, dd, yyf, mmf, ddf, valor)
        {
            codigo = c;
            descripcion = d;
            likes = l;
           

        }
        public string codigo{get; set;}   
        public string descripcion{get; set;}
        
        public int likes;
        public string getPrecio(string FechaX)
        {
            
            return FechaX;
        }
        
    }
    //Declaracion de la clase ProductoDB

    class ProductoDB
    {
        //Creacion del archivo de texto
        public static void Lista(string path, List<Producto> items)
        {
            StreamWriter txtOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            foreach(Producto p in items)
            {
                txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", p.codigo, p.descripcion, p.likes, p.Precio, p.FechaInicio, p.FechaFinal);
            }
            txtOut.Close();
        }
      
        //Leer del archivo de texto
        public static List<Producto> ReadFromTXT(string path)
        {
            List<Producto> Electronica = new List<Producto>();
            StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
            while(txtIn.Peek() != -1)
            {
                string line = txtIn.ReadLine();
                string[] columns = line.Split('|');
                Producto p = new Producto(1,2,2,2,2,2, Int32.Parse(columns[3]), columns[0], columns[1], Int32.Parse(columns[2]));
                Electronica.Add(p);
            }
            return Electronica;
        }
    }
       
    class PrecioFecha
    {
        //Declaracion de atributos de la clase
        public DateTime FechaInicio;
        public DateTime FechaFinal;
        public Decimal Precio;
        //Constructor de la clase
        public PrecioFecha(int yy, int mm, int dd, int yyf, int mmf, int ddf, int valor)
        {
            FechaInicio = new DateTime(yy, dd, mm);
            FechaFinal = new DateTime(yyf, ddf, mmf);
            Precio = valor;  

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de la lista Electronica
            List<Producto> Electronica = new List<Producto>();
            Electronica.Add(new Producto(2018, 6, 6, 2020, 7, 6, 3000,"0000", "Nintendo DSi XL", 1100));
            Electronica.Add(new Producto(2020, 6, 6, 2019, 9, 6, 9800,"0001", "Samsung Galaxy S10+", 4800));
            Electronica.Add(new Producto(2009, 6, 6, 2020, 10, 6, 10000,"0002", "GTX GeForce Nvidia 2080Ti", 69));
            //Declaracion de la lista abarrotes
            List<Producto> Abarrotes = new List<Producto>();
            Abarrotes.Add(new Producto(2020, 5, 5, 2020, 5, 12, 35,"0003", "Pan de barra BIMBO", 50));
            Abarrotes.Add(new Producto(2020, 5, 6, 2020, 5, 12, 42,"0004", "Jamon virgina BAFAR", 30));
            Abarrotes.Add(new Producto(2020, 4, 5, 2020, 5, 12, 32,"0005", "Queso amarillo FUD", 40));
            //Declaracion de la lista Miscelanea
            List<Producto> Miscelanea = new List<Producto>();
            Miscelanea.Add(new Producto(2020, 5, 5, 2020, 5, 12, 50,"0006", "Hojas de Roble", 13));
            Miscelanea.Add(new Producto(2020, 5, 5, 2020, 5, 12, 250,"0007", "Valla de Roble oscuro", 80));
            Miscelanea.Add(new Producto(2020, 5, 5, 2020, 5, 12, 149,"0008", "Peonía", 99));
            //Lista que lee los archivos de texto
            List<Producto> Lector = new List<Producto>();

            //Llamada al procedimiento Lista
           ProductoDB.Lista("Electronica.txt", Electronica); 
            ProductoDB.Lista("Abarrotes.txt", Abarrotes);
            ProductoDB.Lista("Miscelanea.txt", Miscelanea);

            Console.WriteLine("Productos actuales en inventario:"); 
            Lector = ProductoDB.ReadFromTXT(@".\Electronica.txt");
            foreach(Producto p in Lector)
            {
                Console.WriteLine("Codigo: {0} Descripcion: {1} Likes: {2} Precio: ${3}", p.codigo, p.descripcion, p.likes, p.Precio);
            }

            Lector = ProductoDB.ReadFromTXT(@".\Abarrotes.txt");
            foreach(Producto p in Lector)
            {
                Console.WriteLine("Codigo: {0} Descripcion: {1} Likes: {2} Precio: ${3}", p.codigo, p.descripcion, p.likes, p.Precio);
            }

            Lector = ProductoDB.ReadFromTXT(@".\Miscelanea.txt");
            foreach(Producto p in Lector)
            {
                Console.WriteLine("Codigo: {0} Descripcion: {1} Likes: {2} Precio: ${3}", p.codigo, p.descripcion, p.likes, p.Precio);
            }

            
            
        }
    }
}
