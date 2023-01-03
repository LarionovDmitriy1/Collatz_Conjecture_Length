using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_Conjecture_Length;

public class CollatzConjectureLength
{
    public static int Collatz(int n)
    {
        int counter = 0;
        for (int i = 0; ; i++)
        {
            if (n == 1 || n == -1) { counter++; break; }
            if (n % 2 == 0)
            {
                n = n / 2;
                counter++;
            }
            else
            {
                n = n * 3 + 1;
                counter++;
            }
        }
        return counter;
    }
}
