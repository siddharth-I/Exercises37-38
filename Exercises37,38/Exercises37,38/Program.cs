using System;

namespace Exercises37_38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 37
            int[] sumArray = new int[5];
            string continueInput1;
            do
            {
                for (int i = 0; i < sumArray.Length; i++)
                {
                    Console.WriteLine("Enter a number: ");
                    sumArray[i] = int.Parse(Console.ReadLine());
                }
                int sum = sumArray[0] + sumArray[1] + sumArray[2] + sumArray[3] + sumArray[4];
                Console.WriteLine($"{sumArray[0]} + {sumArray[1]} + {sumArray[2]} + {sumArray[3]} + {sumArray[4]} = {sum}");
                Console.WriteLine("Would you like to continue? y / n");
                continueInput1 = Console.ReadLine();
            } while (continueInput1 == "y");
            Console.WriteLine("Goodbye!");
            //Exercise 38
            int[] averageArray = new int[5];
            string continueInput2;
            do
            {
                for (int i = 0; i < averageArray.Length; i++)
                {
                    Console.WriteLine("Enter a number: ");
                    averageArray[i] = int.Parse(Console.ReadLine());
                }
                int average = (averageArray[0] + averageArray[1] + averageArray[2] + averageArray[3] + averageArray[4]) / (averageArray.Length);
                Console.WriteLine($"({averageArray[0]} + {averageArray[1]} + {averageArray[2]} + {averageArray[3]} + {averageArray[4]}) / {averageArray.Length} = {average}");
                Console.WriteLine("Would you like to continue? y / n");
                continueInput2 = Console.ReadLine();
            } while (continueInput2 == "y");
            Console.WriteLine("Goodbye!");
        }
    }
}
