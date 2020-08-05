using System;

namespace KIT506_Programming_Practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] counts = { 1, 0, 5, 7, 4, 2, 1 };
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine(i + " | " + counts[i]);
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Console.Write(i + " | ");
                for(int j = 0; j < counts[i]; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}
