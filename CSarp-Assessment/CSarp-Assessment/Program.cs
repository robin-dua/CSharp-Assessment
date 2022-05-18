using System;
using CSarp_Assessment;
public class Solution
{
    public static void Main()
    {
        string UserDecision = string.Empty;
        Console.WriteLine("Please select the choice which program do you want to run:");
        Console.WriteLine("1.Number Triangle\n 2.Display Multiplication Table\n 3.Pyramid Pattern\n 4.Sum of Digits");
        do
        {
            int UserChoice;
            do
            {
                Console.WriteLine("Please enter your choice:");
                UserChoice = Convert.ToInt32(Console.ReadLine());
                switch (UserChoice)
                {
                    case 1:
                        NumberTriangle T1 = new NumberTriangle();
                        T1.myTriangle();
                        break;
                    case 2:
                        MultiplicationTable M1 = new MultiplicationTable();
                        M1.myTable();
                        break;
                    case 3:
                        PyramidPattern P1 = new PyramidPattern();
                        P1.myPyramid();
                        break;
                    case 4:
                        SumOfDigits S1 = new SumOfDigits();
                        S1.mySum();
                        break;
                    default:
                        Console.WriteLine("Your choice {0} is invalid", UserChoice);
                        break;
                }
            } while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3 && UserChoice != 4);
            do
            {
                Console.WriteLine("Do you want to continue:");
                UserDecision = Console.ReadLine().ToUpper();
                if (UserDecision != "YES" && UserDecision != "NO")
                {
                    Console.WriteLine("Your choice {0} is invalid", UserDecision);
                }
            } while (UserDecision != "YES" && UserDecision != "NO");

        } while (UserDecision.ToUpper() != "NO");

    }
}
