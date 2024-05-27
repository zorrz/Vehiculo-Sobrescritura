using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class CambioAceite : Servicio
    { 
        //Sobrescribimos con override los 3 metodos de la clase base Servicio y añadimos implementacion
        //que nos da un valor o un mensaje. 
        public override double CalcularCosto()
        {
            return 50.0; //Costo del cambio de aceite.
        }

        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando cambio de aceite.");
        }

        public override double TiempServicio()
        {
            return 1.0;//Tiempo del cambio de aceite.
        }
    }
}
