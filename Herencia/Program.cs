using System;
namespace Herencia
{
    class Alumno
    {
        protected string name;
        protected string ServicioSocial;
        protected string Residencia;
        protected string Investigacion;
        public Alumno (string n)
        {
            name= n;
        } 
        public virtual void Presentate()
        {
            Console.WriteLine("Mi nombre es: {0}", name);
        }
    }
    class Licenciatura:Alumno
    {
        protected string lic;
        public Licenciatura(string name, String lic):base(name)
        {
            this.lic=lic;
        }
        public new void ServicioSocial()
        {
             Console.WriteLine("Este es mi servicio social: {0}",lic);
        }
        public new void Residencia()
        {
             Console.WriteLine("Esta es mi Residencia: {0}", lic);
        } 
    }
    class Posgrado:Alumno
    {
        protected string pos;
        public Posgrado(string name, String pos):base(name)
        {
            this.pos=pos;
        }
        public new void Investigacion()
        {
            Console.WriteLine("Mi invetigacion es: {0}",pos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumno Ricardo = new Alumno("Ricardo");
            Ricardo.Presentate();
            Licenciatura Elizabeth = new Licenciatura("Elizabeth","Doc1");
            Elizabeth.Presentate();
            Elizabeth.ServicioSocial();
            Elizabeth.Residencia();
            Posgrado Ximena =new Posgrado("Ximena","Doc1");
            Ximena.Presentate();
            Ximena.Investigacion();
        }
    }
}
