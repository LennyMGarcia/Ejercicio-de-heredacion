using System;

/// <summary>
/// Este es un ejercicio practico que trata sobre la heredacion de la clase 
/// vehiculos
/// </summary>
namespace Ejercicio_de_heredacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo Todos = new Vehiculo();
            Coche VMW = new Coche();
            Avion ak47 = new Avion();

            Vehiculo[] muchos = new Vehiculo[3];
            muchos[0] = Todos;
            muchos[1] = VMW;
            muchos[2] = ak47;

           
            for (int i=0; i<3;i++)
            {
                muchos[i].conducir();
            }
        }
    }
    class Vehiculo
    {
        public void arrancarMotor() => Console.WriteLine("Yo arranco el motro");
        public void pararMotro() => Console.WriteLine("Yo paro el motro");
        public virtual void conducir() => Console.WriteLine("Yo conduzco como todos");
    }

    class Avion:Vehiculo
    {
        public void Volar() => Console.WriteLine("Yo arranco el motro");
        public override void conducir() => Console.WriteLine("Yo conduzco en el aire");
    }

    class Coche : Vehiculo
    {
        public void subirSuperficie() => Console.WriteLine("Yo arranco el motro");
        public override void conducir() => Console.WriteLine("Yo conduzco en el suelo");
    }
}
