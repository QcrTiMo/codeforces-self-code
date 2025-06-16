/***
 * A. Calculating Function
time limit per test1 second
memory limit per test256 megabytes
For a positive integer n let's define a function f:

f(n) =  - 1 + 2 - 3 + .. + ( - 1)nn

Your task is to calculate f(n) for a given integer n.

Input
The single line contains the positive integer n (1 ≤ n ≤ 1015).

Output
Print f(n) in a single line.

Examples
Input
4
Output
2
Input
5
Output
-3
Note
f(4) =  - 1 + 2 - 3 + 4 = 2

f(5) =  - 1 + 2 - 3 + 4 - 5 =  - 3
 * ***/


using System.Numerics;

namespace A._Calculating_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long result = 0;
            if (n % 2 == 0)
            {
                result = n / 2;
            }
            else
            {
                result = -(n + 1) / 2;
            }
            Console.WriteLine(result);
        }
    }
}
