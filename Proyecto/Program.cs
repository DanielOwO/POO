using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto
{
    class Producto
    {
        protected string codigo;      
        protected string descripcion;
        protected int precios;
        protected int likes;
    }

    class ProductoDB
    {

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
            List<Producto> productos = new List<Producto>();
            Console.WriteLine("Hello World!");
        }
    }
}
