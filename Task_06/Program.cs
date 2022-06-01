using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {

            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();

            //   CancellationToken ct = cancelTokenSource.Token;
            //  Task tarea2 = Task.Run(() => Tarea02(ct));
            // ct.Cancel();


            Task tarea1 = Task.Run(Tarea01);

            Task tarea2 = Task.Run(() => Tarea02(cancelTokenSource.Token));

            Task tarea3 = Task.Run(Tarea03);

            Task tarea4 = Task.Run(() => Tarea04(cancelTokenSource.Token));

            Thread.Sleep(3000);

            cancelTokenSource.Cancel();


            Task.WaitAll(tarea1, tarea2, tarea3, tarea4);

            Console.WriteLine("Terminado todo");
        }


        public static void Tarea01()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Tarea 1");

        }
        public static void Tarea02(CancellationToken cancelToken)
        {
            int i = 1;
            while (true)
            {
                if (!cancelToken.IsCancellationRequested)
                {

                    Thread.Sleep(500);
                    Console.WriteLine("Tarea 2 : " + i);
                    i++;
                }
                else
                {
                    Console.WriteLine("tarea 2 cancelada");
                    return;
                }

            }

        }
        public static void Tarea03()
        {
            Thread.Sleep(9000);
            Console.WriteLine("Tarea 3");

        }
        public static void Tarea04(CancellationToken cancelToken)
        {

            Thread.Sleep(5000);
            if (cancelToken.IsCancellationRequested)
            {
                Console.WriteLine("Tarea 4 cancelada");

                return;
            }
            Console.WriteLine("Tarea 4");

        }
    }
}
