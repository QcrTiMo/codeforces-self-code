/***
 * A. Beautiful Year
time limit per test2 seconds
memory limit per test256 megabytes
It seems like the year of 2013 came only yesterday. Do you know a curious fact? The year of 2013 is the first year after the old 1987 with only distinct digits.

Now you are suggested to solve the following problem: given a year number, find the minimum year number which is strictly larger than the given one and has only distinct digits.

Input
The single line contains integer y (1000 ≤ y ≤ 9000) — the year number.

Output
Print a single integer — the minimum year number that is strictly larger than y and all it's digits are distinct. It is guaranteed that the answer exists.

Examples
Input
1987
Output
2013
Input
2013
Output
2014

 * ***/


namespace A._Beautiful_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            while (true)
            {
                y++;
                String currentyear = y.ToString();
                HashSet<char> years = new HashSet<char>();
                bool allunique = true;
                foreach (char c in currentyear)
                {
                    if (years.Contains(c))
                    {
                        allunique = false;
                        break;
                    }
                    else
                    {
                        years.Add(c);
                    }
                }
                if (allunique)
                {
                    Console.WriteLine(y);
                    break;
                }
            }
        }
    }
}
