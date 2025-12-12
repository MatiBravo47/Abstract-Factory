using System;
// Abstract Factory: Sirve para crear familias de objetos relacionados
namespace AbstractFactory
{
    //Toda fábrica debe poder crear un Silla y mesa.
    public interface IFabricaMuebles
    {
        ISilla CrearSilla();
        IMesa CrearMesa();
    }
    //Fábrica moderna
    class FabricaModerna : IFabricaMuebles
    {
        public ISilla CrearSilla()
        {
            return new SillaModerna();
        }

        public IMesa CrearMesa()
        {
            return new MesaModerna();
        }
    }
    //Fabrica victoriana 
    class FabricaVictoriana : IFabricaMuebles
    {
        public ISilla CrearSilla()
        {
            return new SillaVictoriana();
        }

        public IMesa CrearMesa()
        {
            return new MesaVictoriana();
        }
    }

    public interface ISilla
    {
        string Descripcion();
    }

    class SillaModerna : ISilla
    {
        public string Descripcion()
        {
            return "Silla moderna minimalista";
        }
    }

    class SillaVictoriana : ISilla
    {
        public string Descripcion()
        {
            return "Silla victoriana clásica";
        }
    }

    public interface IMesa
    {
        string Descripcion();
        string CombinarConSilla(ISilla silla);
    }

    class MesaModerna : IMesa
    {
        public string Descripcion()
        {
            return "Mesa moderna de vidrio templado";
        }

        public string CombinarConSilla(ISilla silla)
        {
            var s = silla.Descripcion();
            return $"La mesa moderna combina con {s}";
        }
    }

    class MesaVictoriana : IMesa
    {
        public string Descripcion()
        {
            return "Mesa victoriana de madera tallada";
        }

        public string CombinarConSilla(ISilla silla)
        {
            var s = silla.Descripcion();
            return $"La mesa victoriana combina con: {s}";
        }
    }

    class Cliente
    {
        public void Main()
        {
            Console.WriteLine("== Probando muebles modernos == ");
            ProbarMuebles(new FabricaModerna());
            
            Console.WriteLine();

            Console.WriteLine("== Probando muebles victorianos ==");
            ProbarMuebles(new FabricaVictoriana());
        }

        public void ProbarMuebles(IFabricaMuebles fabrica)
        {
            var silla = fabrica.CrearSilla();
            var mesa = fabrica.CrearMesa();

            Console.WriteLine(silla.Descripcion());
            Console.WriteLine(mesa.Descripcion());
            Console.WriteLine(mesa.CombinarConSilla(silla));
        }
    }
    class Program 
    {
        static void Main(string[] args) 
        {
            new Cliente().Main();
        }
    }
}