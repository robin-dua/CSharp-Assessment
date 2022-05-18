using System;

namespace CSarp_Assessment
{
    public class NumberTriangle
    {
        public void myTriangle()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(number);
                }

                Console.WriteLine();
                width--;
            }
        }
    }
}
