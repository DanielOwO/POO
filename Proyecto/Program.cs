using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto
{
    //Declaracion de la clase producto
    class Producto
    {
        //Constructor
        public Producto(string c, string d)
        {
            codigo = c;
            descripcion = d;

        }
        public string codigo{get; set;}   
        public string descripcion{get; set;}
        List<PrecioFecha> precios;
        public int likes;
        public void getPrecio()
        {
            
        }
    }
    //Declaracion de la clase ProductoDB

    class ProductoDB
    {
        public static void WriteToTXT(string path, List<Producto> productos)
        {
            StreamWriter txtOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            foreach(Producto p in productos)
            {
                txtOut.WriteLine("{0}|{1}", p.codigo, p.descripcion);
            }
            txtOut.Close();
        }
    }
    class PrecioFecha
    {
        DateTime FechaInicio;
        DateTime FechaFinal;
        Decimal Precio;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de la lista productos
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("0000", "Nintendo DSi XL"));
            productos.Add(new Producto("0001", "Samsung Galaxy S10+"));
            productos.Add(new Producto("0002", "GTX GeForce Nvidia 2080Ti"));
            //Llamada al procedimiento writetoTXT
            ProductoDB.WriteToTXT("productos.txt", productos);
            Console.WriteLine("Hello World!");
        }
    }
}
