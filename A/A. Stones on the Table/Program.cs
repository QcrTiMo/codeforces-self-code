﻿/***
 * A. Stones on the Table
time limit per test2 seconds
memory limit per test256 megabytes
There are n stones on the table in a row, each of them can be red, green or blue. Count the minimum number of stones to take from the table so that any two neighboring stones had different colors. Stones in a row are considered neighboring if there are no other stones between them.

Input
The first line contains integer n (1 ≤ n ≤ 50) — the number of stones on the table.

The next line contains string s, which represents the colors of the stones. We'll consider the stones in the row numbered from 1 to n from left to right. Then the i-th character s equals "R", if the i-th stone is red, "G", if it's green and "B", if it's blue.

Output
Print a single integer — the answer to the problem.

Examples
Input
3
RRG
Output
1
Input
5
RRRRR
Output
4
Input
4
BRBG
Output
0
 * ***/


namespace A._Stones_on_the_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            String stones = Console.ReadLine();
            int stonesToRemove = 0;
            for (int i = 0;i < n - 1; i++)
            {
                if (stones[i] == stones[i + 1])
                {
                    stonesToRemove++;
                }
            }
            Console.WriteLine(stonesToRemove);
        }
    }
}
