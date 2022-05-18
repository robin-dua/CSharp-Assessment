/* Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk. */
/* Expected output:
   *
  * * 
 * * *
* * * *  */

using System;

namespace CSarp_Assessment
{
    public class PyramidPattern
    {
        public void myPyramid()
        {
            int i, j, space, rows, k;
            Console.Write("Enter number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            space = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = space; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
                space--;
            }
        }
    }
}
