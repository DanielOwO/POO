using System;

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
            Console.WriteLine("Hello World!");
        }
    }
}
