/***
 * A. Divisibility Problem
time limit per test1 second
memory limit per test256 megabytes
You are given two positive integers a
 and b
. In one move you can increase a
 by 1
 (replace a
 with a+1
). Your task is to find the minimum number of moves you need to do in order to make a
 divisible by b
. It is possible, that you have to make 0
 moves, as a
 is already divisible by b
. You have to answer t
 independent test cases.

Input
The first line of the input contains one integer t
 (1≤t≤104
) — the number of test cases. Then t
 test cases follow.

The only line of the test case contains two integers a
 and b
 (1≤a,b≤109
).

Output
For each test case print the answer — the minimum number of moves you need to do in order to make a
 divisible by b
.

Example
Input
5
10 4
13 9
100 13
123 456
92 46
Output
2
5
4
333
0


 * ***/


using System.Text;

namespace A._Divisibility_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0;i < n; i++)
            {
                String[] input = Console.ReadLine().Split(" ");
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int step;
                if (a % b == 0)
                {
                    step = 0;
                }
                else
                {
                    int temp = a % b;
                    step = b - temp;
                }
                Console.WriteLine(step);
            }
        }
    }
}
