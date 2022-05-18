/* Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number. */
/* 666666                                                      
   66666                                                           
   6666                                                                  
   666                                                        
   66                                                                  
   6 */

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
