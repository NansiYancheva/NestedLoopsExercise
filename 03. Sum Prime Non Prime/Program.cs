using System;
namespace NestedLoopsExercise
{
    class Program
    {
        static void Main()
        {
            string command;
            int nonPrimeSum = 0;
            int primeSum = 0;
            while ((command = Console.ReadLine()) != "stop")
            {
                int currNum = int.Parse(command);
                //ако е отрицателно число
                if (currNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                //ако е нула
                else if (currNum == 0)
                {
                    nonPrimeSum += currNum;
                    continue;
                }
                //дали са прости или не
                bool isPrime = true;
                for (int div = 2; div < currNum; div++)
                {
                    if (currNum % div == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                    if (isPrime)
                        primeSum += currNum;
                    else
                        nonPrimeSum += currNum;
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}

