using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_07
{
    internal class GestorDatos
    {


        public static string TraerRegistros()
        {
            
            return "La cantidad de registros es 2000";
        }

        public static async Task<string> TraerRegistros2Async() // t0
        {
            //t0
            string informacion = await Task.Run(() =>
                                            {
                                                Thread.Sleep(10000); // SIMULO QUE VA A LA BASE
                                            return "La cantidad de registros es 2000";
                                            });
             
            if(informacion.Length < 0)
            {
                throw new Exception("info vacia");
            }

            return informacion;
        }

    }
}
