﻿/***
 * A. Word
time limit per test2 seconds
memory limit per test256 megabytes
Vasya is very upset that many people on the Net mix uppercase and lowercase letters in one word. That's why he decided to invent an extension for his favorite browser that would change the letters' register in every word so that it either only consisted of lowercase letters or, vice versa, only of uppercase ones. At that as little as possible letters should be changed in the word. For example, the word HoUse must be replaced with house, and the word ViP — with VIP. If a word contains an equal number of uppercase and lowercase letters, you should replace all the letters with lowercase ones. For example, maTRIx should be replaced by matrix. Your task is to use the given method on one given word.

Input
The first line contains a word s — it consists of uppercase and lowercase Latin letters and possesses the length from 1 to 100.

Output
Print the corrected word s. If the given word s has strictly more uppercase letters, make the word written in the uppercase register, otherwise - in the lowercase one.

Examples
Input
HoUse
Output
house
Input
ViP
Output
VIP
Input
maTRIx
Output
matrix
 * ***/


namespace A._Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upper = 0;
            int lower = 0;
            String input = Console.ReadLine();
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    upper++;
                }
                else
                {
                    lower++;
                }
            }
            String result;
            if (upper > lower)
            {
                result = input.ToUpper();
            }
            else
            {
                result = input.ToLower();
            }
            Console.WriteLine(result);
        }
    }
}
