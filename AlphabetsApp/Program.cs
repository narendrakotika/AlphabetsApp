// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Alphabet Table:");

        // Print header
        Console.WriteLine("  A B C D E F G H I J K L M");
        Console.WriteLine(" ----------------------------");

        // Print rows
        for (int row = 0; row < 6; row++)
        {
            Console.Write($"{row + 1}|");
            for (int col = 0; col < 13; col++)
            {
                char alphabetChar = (char)('A' + col + row * 13);
                if (alphabetChar <= 'Z')
                {
                    Console.Write($" {alphabetChar}");
                }
            }
            Console.WriteLine();
        }

       
    }
}

