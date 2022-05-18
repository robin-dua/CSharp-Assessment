using System;

namespace CSarp_Assessment
{
    public class SumOfDigits
    {
        public void mySum()
        {
            int SumCal(int n)
            {
                string n1 = Convert.ToString(n);
                int sum = 0;
                for (int i = 0; i < n1.Length; i++)
                    sum += Convert.ToInt32(n1.Substring(i, 1));
                return sum;
            }

            int number;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the number {0} is : {1}", number, SumCal(number));
        }
    }
}
