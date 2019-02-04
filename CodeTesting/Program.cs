using System.Linq;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //initial array
            var arry = new int[6] {1,2,3,4,5,6 };
            //sorting array
            arry = arry.GroupBy(x => x % 2 == 0).SelectMany(g => g).ToArray();
        }
    }
}
