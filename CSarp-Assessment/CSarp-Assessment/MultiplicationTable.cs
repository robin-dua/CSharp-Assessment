using System;

namespace CSarp_Assessment
{
    public class MultiplicationTable
    {
        public void myTable()
        {
            int j, i, n, m;
            Console.Write("Enter a number for the table of: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number until table will be displayed : ");
            m = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= m; i++)
            {
                for (j = n; j <= n; j++)
                {
                    if (j <= n - 1)
                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                    else
                        Console.Write("{0}x{1} = {2}", j, i, i * j);

                }
                Console.Write("\n");
            }
        }
    }
}
