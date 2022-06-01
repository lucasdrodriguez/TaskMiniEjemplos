using System;
using System.Threading.Tasks;
using System.Threading;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task tarea1 = new Task(() =>
                                     {
                                         Thread.Sleep(3000);
                                         Console.WriteLine("Primera tarea");

                                     }
              );

            tarea1.Start();

            Console.WriteLine("Segunda tarea");

            Console.WriteLine("Tercera tarea");

            Thread.Sleep(5000);
        }



    }
}
