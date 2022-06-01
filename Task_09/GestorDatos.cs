using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_09
{
    internal class GestorDatos
    {


        public static string TraerRegistros()
        {

            Thread.Sleep(10000);
            return "La cantidad de registros es 2000";
        }

        public static async Task<string> TraerRegistros2(CancellationToken cancelToken)
        {
            string informacion = await Task.Run(async () =>
                                     { 
                                         await Task.Delay(3000);

                                         cancelToken.ThrowIfCancellationRequested();

                                         //if (cancelToken.IsCancellationRequested)
                                         //{

                                         //    throw new TaskCanceledException("Proceso cancelador por usuario");
                                         //}

                                         await Task.Delay(2000);

                                         return "La cantidad de registros es 2000";

                                     });

            return informacion;
        }

    }
}
