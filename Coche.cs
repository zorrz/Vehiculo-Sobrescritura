using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Coche : Vehiculo
    {
        /* Lo que hacemos en esta clase es sobrescribir con override 3 metodos de la clase base Vehiculo y darles valores distintos.
        Tambien utilizamos el ocultamiento de metodos con el new para el metodo Lavar, para que solo se pueda acceder a el 
        apartir de un obejeto de la clase coche de tipo coche.*/
        public override void RealizarMantenimiento ()
        {
            Console.WriteLine("Realizando mantenimiento del coche: cambio de aceite y revision de frenos.");
        }
        public override double ObtenerCostoMantenimiento()
        {
            return 150.0; //Costo del mantenimiento del coche.
        }
        public override double TiempMantenimiento()
        {
            return 3.0; //horas
        }

        //Ocultamiento de metodos
        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y shampoo especial.");
        }
    }
}
