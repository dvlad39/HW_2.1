using System;

namespace HW_2
{

    class Triangle
    {
        static void Main(string[] args)
        {



            for (int i = 0; i <= 12; i += 2)
            {
                for (int j = 0; j < 12 - i - 1; j += 2)
                {
                    Console.Write("  ");
                }
                for (int x = 12 - i - 1; x < 12; x++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

        }
    }
}

