namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Holi");
            //Polimorfismo
            //creamos un objeto de la clase coche de tipo vehiculo
            Vehiculo miCoche = new Coche();
            miCoche.RealizarMantenimiento();
            Console.WriteLine("Costo del mantenimiento del coche: $" + miCoche.ObtenerCostoMantenimiento());
            Console.WriteLine();
            
            //creamos un objeto de la clase moto de tipo vehiculo
            Vehiculo miMoto = new Moto();
            miMoto.RealizarMantenimiento();
            Console.WriteLine("Costo del mantenimiento de la moto: $" + miMoto.ObtenerCostoMantenimiento());

            Console.WriteLine();
            miCoche.Lavar();

            //Instancia para poder acceder al metodo oculto lavar que esta en la clase Coche.
            Coche miCocheReal = new Coche(); 
            miCocheReal.Lavar();

            //Servicio servicio = new Servicio(); No se puede crear una instancia de la clase adstracta

            //Instancias para los servicios de cambio de acite y reparacion de frenos
            Console.WriteLine();
            Servicio cambioAceite = new CambioAceite();
            cambioAceite.RealizarServicio();
            Console.WriteLine("Costo del cambio de aceite: $" + cambioAceite.CalcularCosto());

            Console.WriteLine();
            Servicio frenos = new ReparacionFrenos();
            frenos.RealizarServicio();
            Console.WriteLine("Costo de la reparacion de frenos: $" + frenos.CalcularCosto());

            //Mandamos a llamar al metodo mostrar informacion de tiempo en la clase metodos para calcular tiempo.
            Console.WriteLine();
            MetodoParaCalcularTiempo.MostrarInformacionDeTiempo(miCoche,miMoto,cambioAceite,frenos);
        }
    }
}
