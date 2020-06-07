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
        public static void WriteToTXT(string path, List<Producto> productos)
        {
            StreamWriter txtOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            foreach(Producto p in productos)
            {
                txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", p.codigo, p.descripcion, p.likes, p.Precio, p.FechaInicio, p.FechaFinal);
            }
            txtOut.Close();
        }
        //Leer del archivo de texto
        /*public static List<Producto> ReadFromTXT(string path)
        {
            List<Producto> productos = new List<Producto>();
            StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
            while(txtIn.Peek() != -1)
            {
                string line = txtIn.ReadLine();
                string[] columns = line.Split('|');
                Producto p = new Producto(0,0,0,0,0,0, Int32.Parse(columns[3]), columns[0], columns[1], Int32.Parse(columns[2]));
                productos.Add(p);
            }
            return productos;
        }*/
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
            //Declaracion de la lista productos
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto(2018, 6, 6, 2020, 7, 6, 3000,"0000", "Nintendo DSi XL", 1100));
            productos.Add(new Producto(2020, 6, 6, 2019, 9, 6, 9800,"0001", "Samsung Galaxy S10+", 4800));
            productos.Add(new Producto(2009, 6, 6, 2020, 10, 6, 10000,"0002", "GTX GeForce Nvidia 2080Ti", 69));

            //Llamada al procedimiento writetoTXT
           ProductoDB.WriteToTXT("productos.txt", productos); 
            Console.WriteLine("Productos actuales en inventario:"); 
           // productos = ProductoDB.ReadFromTXT(@".\productos.txt");

          //  foreach(Producto p in productos)
          //  {
          //      Console.WriteLine("Codigo: {0} Descripcion: {1} Likes: {2} Precio: ${3}", p.codigo, p.descripcion, p.likes, p.Precio);
           // }
            
        }
    }
}
