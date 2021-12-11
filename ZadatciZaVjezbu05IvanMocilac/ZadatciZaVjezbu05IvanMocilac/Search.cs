using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatciZaVjezbu05IvanMocilac
{
    class Search
    {
        public int BinarySearch(int[] arr, int x)
        {
            int nisko = 0;
            int visoko = arr.Length - 1;
            int srednje;

            while(nisko <= visoko)
            {
                srednje = (nisko + visoko) / 2;
                if (x > arr[srednje])
                {
                    nisko = srednje + 1;
                }
                else if (x < arr[srednje])
                {
                    visoko = srednje - 1;
                }
                else
                {
                    return srednje;
                }
            }
            return -1;
        }
    }
}
