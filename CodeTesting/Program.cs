using System;
using System.Linq;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //initial array
            var arry = new int[6] {2,1,2,3,4,5 };
            //grouping array
            arry = arry.GroupBy(x => x % 2 == 0).SelectMany(g => g).ToArray();
            //making sure odd first
            if (arry.First() % 2 == 0)
            {
                Array.Reverse(arry);
            }
            //printing
            foreach (var n in arry)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
