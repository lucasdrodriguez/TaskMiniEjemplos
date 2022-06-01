using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<string> listaConcurrente = new ConcurrentBag<string>();

            Task tarea2 = Task.Run(() => Tarea02(listaConcurrente));
            Task tarea1 = Task.Run(() => Tarea01(listaConcurrente));

            Thread.Sleep(2000);

            while (tarea1.Status == TaskStatus.Running || tarea2.Status == TaskStatus.Running)
            {
                Console.Clear();
                Console.WriteLine("Numero de elementos:" + listaConcurrente.Count);

                listaConcurrente.TryTake(out string ultimoElemento);
                listaConcurrente.TryPeek(out string anteUltimo);


                Console.WriteLine("\n\nElemento removido:  " + ultimoElemento + "\n\nProximo elemento: " + anteUltimo);

                Thread.Sleep(1000);
            }


            Task.WaitAll(tarea2, tarea1);


            foreach (string item in listaConcurrente)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\nProceso terminado");

            Console.WriteLine("Numero de elementos:" + listaConcurrente.Count);

        }

        public static void Tarea01(ConcurrentBag<string> lista)
        {
            List<string> nombres = new List<string>()
            {
                "Alfy",
                    "Luci",
                    "Zarah",
                    "Sonya",
                    "Rebecka",
                    "Raynell",
                    "Carmelina",
                    "Barbi",
                    "Deana",
                    "Florance",
                    "Ofelia",
                    "Tamarah",
                    "Janis",
                    "Trudie",
                    "Ursa",
                    "Glynnis",
                    "Letisha",
                    "Emiline",
                    "Charo",
                    "Matilde",
                    "Holly",
                    "Myriam",
                    "Nikolia",
                    "Euphemia",
                    "Cthrine",
                    "Georgina",
                    "Carlie",
                    "Avrit",
                    "Becca",
                    "Julia",
                    "Felicity",
                    "Sileas",
                    "Ilysa",
                    "Rahal",
                    "Del",
                    "Francisca",
                    "Walliw",
                    "Minnaminnie",
                    "Katerine",
                    "Valli",
                    "Tiertza",
                    "Wandie",
                    "Alayne",
                    "Sharia",
                    "Erda",
                    "Britta",
                    "Malissia",
                    "Valenka",
                    "Fenelia",
                    "Gianna"
            };

            for (int i = 0; i < nombres.Count; i++)
            {
                lista.Add(nombres[i]);
                Thread.Sleep(900);
            }
        }
        public static void Tarea02(ConcurrentBag<string> lista)
        {
            List<string> niveles = new List<string>()
            {"Sr",
            "Jr",
            "IV",
            "Sr",
            "Jr",
            "II",
            "III",
            "Sr",
            "IV",
            "IV",
            "Sr",
            "Jr",
            "IV",
            "IV",
            "IV",
            "IV",
            "Jr",
            "II",
            "Sr",
            "III",
            "Jr",
            "III",
            "Sr",
            "III",
            "Jr",
            "II",
            "Jr",
            "Sr",
            "II",
            "Jr",
            "III",
            "IV",
            "Jr",
            "IV",
            "II",
            "II",
            "IV",
            "Sr",
            "III",
            "Sr",
            "Sr",
            "IV",
            "III",
            "Jr",
            "Jr",
            "Jr",
            "III",
            "III",
            "III",
            "III"
            };

            for (int i = 0; i < niveles.Count; i++)
            {
                lista.Add(niveles[i]);
                Thread.Sleep(800);
            }

        }


    }
}
