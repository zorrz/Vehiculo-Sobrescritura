using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    /*Esta clase esta hecha para los calculos de tiempo, para no cargar el main y asi solo 
     mandar a llamar al metodo apartir de la clase MetodoParaCalcularTiempo.*/
    public class MetodoParaCalcularTiempo
    {
        /*En este metodo creamos objetos la clase Vehiculo, moto y coche. y de la clase Servicio, servi1 y servi2.
        para los servicios de cambio de aceite y reparacion de frenos. Solo sumamos los tiempos de mantenimiento y servicio*/
        public static double CalcTiemp(Vehiculo Coche, Vehiculo Moto,Servicio Servi1, Servicio Servi2)
        {
            double tiempo = 0;

            tiempo = tiempo + TiempManten(Coche);
            tiempo = tiempo + TiempManten(Moto);
            tiempo = tiempo + TiempServicio(Servi1);
            tiempo = tiempo + TiempServicio(Servi2);

            return tiempo;
        }
        //Creamos un metodo para mostrar el tiempo total de los servicios.
        public static void MostrarInformacionDeTiempo(Vehiculo Coche, Vehiculo Moto, Servicio Servi1, Servicio Servi2)
        {
            double tiempoTotal = CalcTiemp(Coche, Moto, Servi1, Servi2);
            Console.WriteLine($"Tiempo total para los servicios de coche y moto: {tiempoTotal} horas.");
        }

        /*Aqui creamos un objeto de la clase Servicio para obtener el tiempo que dura el servicio.
         Si el servicio es nulo nos retorna el valor 0.
         Si no es nulo manda a llamar al metodo TiempServicio de la clase Servicio para que nos retorne el valor */
        private static double TiempServicio(Servicio servicio)
        {
            if (servicio == null)
            {
                return 0;
            }
            else
            {
                return servicio.TiempServicio();
            }
        }
        //Aqui hacemos lo mismo pero esta vez creamos un objeto de la clase Vehiculo.
        public static double TiempManten(Vehiculo vehiculo)
        {
            if(vehiculo is Coche)
            {
                return vehiculo.TiempMantenimiento();
            }
            else if (vehiculo is Moto)
            {
                return vehiculo.TiempMantenimiento();
            }
            else
            {
                return 0;
            }
        }
    }
}
