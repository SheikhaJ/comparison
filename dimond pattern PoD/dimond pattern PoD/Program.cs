using System;

class Program
{
    static void Main()
    {
        int rows = 10; 
        int midRow = rows / 2;

        for (int i = 0; i <= midRow; i++)
        {
            for (int j = 0; j < rows - i; j++)
                Console.Write(" ");

            for (int k = 0; k <= i * 2; k++)
                Console.Write("*");

            Console.WriteLine();
        }

        for (int i = midRow - 1; i >= 0; i--)
        {
            for (int j = 0; j < rows - i; j++)
                Console.Write(" ");

            for (int k = 0; k <= i * 2; k++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
}
