using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{  
    //Creamos 3 metodos abstracto que deben ser implementados por las clases
    //derivadas cambioAceite y ReparacionFrenos.
    public abstract class Servicio
    {
        public abstract void RealizarServicio();//Devuelve un mensaje.

        public abstract double CalcularCosto(); //Devuelve el precio.
                                                
        public abstract double TiempServicio(); //Devuelve la duracion en horas.
    }
}
