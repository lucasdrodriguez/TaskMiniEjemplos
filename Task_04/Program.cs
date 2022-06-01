using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {

            Task tarea1 = Task.Run(Tarea01); // ignacio compra comida
            Task tarea2 = Task.Run(Tarea02); // raffi a  comprar bebida
            Task tarea3 = Task.Run(Tarea03); // lucia a comprar postres

            tarea3.Wait(); // no sigamos adelante hasta que lucia traiga los postres   

            Console.WriteLine("Terminado todo"); // se va el remis 
        }


        public static void Tarea01()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Tarea 1");

        }
        public static void Tarea02()
        {
            Thread.Sleep(7000);
            Console.WriteLine("Tarea 2");

        }
        public static void Tarea03()
        {
            Thread.Sleep(9000);
            Console.WriteLine("Tarea 3");

        }
    }
}
