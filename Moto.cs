using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Moto : Vehiculo

    {   //Sobrescribimos con override 3 metodos de la clase base Vehiculo y le damos valores distintos.
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando el mantenimiento de la moto: lubricacion de cadena y revision de neumaticos.");
        }
        public override double ObtenerCostoMantenimiento()
        {
            return 100.0; //Costo del mantenimiento de la moto;
        }
        public override double TiempMantenimiento()
        {
            return 2.0; //horas
        }
    }
}
