using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//co to są te using na górze? część chyba nie jest potrzebna bo się nie 'świecą'?

namespace Totolotek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***ROZWIĄZANIE PIERWSZE***
            //Console.WriteLine("Witaj w Totolotku, oto twoje 6 liczb");
            //for (int i = 0; i < 6; i++)
            //{
            //    Random rnd = new Random();
            //    int start = 0;
            //    int finish = 60;
            //    int result = rnd.Next(start, finish);
            //    System.Threading.Thread.Sleep(1);

            //    Console.WriteLine(result);
            //}
            //Console.ReadLine();

            //***ROZWIĄZANIE DRUGIE***
            Console.WriteLine("Witaj w Totolotku, oto twoje 6 liczb");
            int[] arr = new int[6];
            int i;
            for (i = 0; i < 6; i++)
            {
                Random rnd = new Random();
                int start = 0;
                int finish = 60;
                int result = rnd.Next(start, finish);
                arr[i] = result;
                System.Threading.Thread.Sleep(1);
            }
            //Console.WriteLine(arr); ---dlaczego nie da się wyświetlić tablicy?
            i = 0;
            foreach (int item in arr)
            {
                Console.WriteLine(item);
                i++;
            }
            Console.ReadLine();
        }
    }
}
