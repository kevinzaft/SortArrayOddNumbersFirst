using System.Linq;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var arry = new int[6] {1,2,3,4,5,6 };
            arry = arry.GroupBy(x => x % 2 == 0).SelectMany(g => g).ToArray();
        }
    }
}
