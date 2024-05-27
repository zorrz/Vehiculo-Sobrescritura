using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class ReparacionFrenos : Servicio
    {
        /*Lo que hacemos en esta clase es sobrescribir 3 metodos de la clase base Servicio y 
         añadimos implementacion que nos devuelve un valor o un mensaje.*/
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando reparacion de frenos.");
        }
        public override double CalcularCosto()
        {
            return 100.0; //Costo de la reparacion de frenos.
        }
        public override double TiempServicio()
        {
           return 1.5; //Tiempo de reparacion de frenos.
        }
    }
}
