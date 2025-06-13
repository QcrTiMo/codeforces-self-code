/***
 * A. Word Capitalization
time limit per test2 seconds
memory limit per test256 megabytes
Capitalization is writing a word with its first letter as a capital letter. Your task is to capitalize the given word.

Note, that during capitalization all the letters except the first one remains unchanged.

Input
A single line contains a non-empty word. This word consists of lowercase and uppercase English letters. The length of the word will not exceed 103.

Output
Output the given word after capitalization.

Examples
Input
ApPLe
Output
ApPLe
Input
konjac
Output
Konjac
 * ***/

using System;
using System.Runtime.CompilerServices;

namespace A._Word_Capitalization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String word = Console.ReadLine();
            char first = word[0];
            char First = char.ToUpper(first);
            String rest = "";
            if (word.Length > 1)
            {
                rest = word.Substring(1);
            }
            String result = First + rest;
            Console.WriteLine(result);
            
        }
    }
}
