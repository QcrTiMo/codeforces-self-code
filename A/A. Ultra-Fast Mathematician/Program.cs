﻿/***
 * A. Ultra-Fast Mathematician
time limit per test2 seconds
memory limit per test256 megabytes
Shapur was an extremely gifted student. He was great at everything including Combinatorics, Algebra, Number Theory, Geometry, Calculus, etc. He was not only smart but extraordinarily fast! He could manage to sum 1018 numbers in a single second.

One day in 230 AD Shapur was trying to find out if any one can possibly do calculations faster than him. As a result he made a very great contest and asked every one to come and take part.

In his contest he gave the contestants many different pairs of numbers. Each number is made from digits 0 or 1. The contestants should write a new number corresponding to the given pair of numbers. The rule is simple: The i-th digit of the answer is 1 if and only if the i-th digit of the two given numbers differ. In the other case the i-th digit of the answer is 0.

Shapur made many numbers and first tried his own speed. He saw that he can perform these operations on numbers of length ∞ (length of a number is number of digits in it) in a glance! He always gives correct answers so he expects the contestants to give correct answers, too. He is a good fellow so he won't give anyone very big numbers and he always gives one person numbers of same length.

Now you are going to take part in Shapur's contest. See if you are faster and more accurate.

Input
There are two lines in each input. Each of them contains a single number. It is guaranteed that the numbers are made from 0 and 1 only and that their length is same. The numbers may start with 0. The length of each number doesn't exceed 100.

Output
Write one line — the corresponding answer. Do not omit the leading 0s.

Examples
Input
1010100
0100101
Output
1110001
Input
000
111
Output
111
Input
1110
1010
Output
0100
Input
01110
01100
Output
00010

 * ***/


using System.Text;

namespace A._Ultra_Fast_Mathematician
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String input1 = Console.ReadLine();
            String input2 = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0;i < input1.Length; i++)
            {
                char str1 = input1[i];
                char str2 = input2[i];
                if (str1 == str2)
                {
                    result.Append(0);
                }
                else
                {
                    result.Append(1);
                }
            }
            Console.WriteLine(result);
        }
    }
}
