using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Vehiculo
    {
        /*Creamos 3 metodos de mantenimiento, virtual para que puedan ser sobrescritos y 
         * creamos un metodo lavar que no es virtual solo para que imprima un mensaje */
        public virtual void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento general del vehiculo");
        }
        public virtual double ObtenerCostoMantenimiento()
        {
            return 50.0; //costo base del mantenimiento general
        }
        public virtual double TiempMantenimiento() 
        {
            return 1.0; //tiempo base del mantenimiento general
        }
      
        public void Lavar()
        {
            Console.WriteLine("Lavando el vehiculo");
        }
    }
}
