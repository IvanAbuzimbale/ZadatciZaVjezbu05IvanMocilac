using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatciZaVjezbu05IvanMocilac
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int y = 1;
            for (int i = 0; i < 100; i++)
            {
                arr[i] = y;
                y = y + 2;
            }
            Search search = new Search();
            Console.WriteLine(search.BinarySearch(arr, 75));
            Console.ReadKey();
        }
    }
}
