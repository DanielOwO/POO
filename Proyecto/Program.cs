using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto
{
    //Declaracion de la clase producto
    class Producto:PrecioFecha
    {
        //Constructor
        public Producto(string c, string d, int l, int p)
        {
            codigo = c;
            descripcion = d;
            likes = l;
            precio = p;

        }
        public string codigo{get; set;}   
        public string descripcion{get; set;}
        public int precio;
        public int likes;
        public string getPrecio(string FechaX)
        {
            //precios = new List<PrecioFecha>();
            return FechaX;
        }
        public int GetDepartment(int Depto)
        {
            return 0;
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
                txtOut.WriteLine("{0}|{1}|{2}|{3}", p.codigo, p.descripcion, p.likes,p.precio);
            }
            txtOut.Close();
        }
        //Leer del archivo de texto
        public static List<Producto> ReadFromTXT(string path)
        {
            List<Producto> productos = new List<Producto>();
            StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
            while(txtIn.Peek() != -1)
            {
                string line = txtIn.ReadLine();
                string[] columns = line.Split('|');
                Producto p = new Producto(columns[0], columns[1], Int32.Parse(columns[2]), Int32.Parse(columns[3]));
                productos.Add(p);
            }
            return productos;
        }
    }
    class PrecioFecha
    {
        public DateTime FechaInicio = new DateTime();
        public DateTime FechaFinal;
        public Decimal Precio;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de la lista productos
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("0000", "Nintendo DSi XL", 10, 3000));
            productos.Add(new Producto("0001", "Samsung Galaxy S10+", 43, 9800));
            productos.Add(new Producto("0002", "GTX GeForce Nvidia 2080Ti", 69, 10000));
            //Llamada al procedimiento writetoTXT
            ProductoDB.WriteToTXT("productos.txt", productos); 
            Console.WriteLine("Productos actuales en inventario:"); 
            productos = ProductoDB.ReadFromTXT(@".\productos.txt");

            foreach(Producto p in productos)
            {
                Console.WriteLine("Codigo: {0} Descripcion: {1} Likes: {2} Precio: ${3}", p.codigo, p.descripcion, p.likes, p.precio);
            }
        }
    }
}
