using System;
namespace NestedLoopsExercise
{
    class Program
    {
        static void Main()
        {
            int begginingNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (int counter = begginingNumber; counter <= endNumber; counter++)
            {
                int evenSum = 0;
                int oddSum = 0;
                int position = 6;
                int currNum = counter;
                while (currNum > 0)
                {
                    //123464 % 10 = 4
                    int currDigit = currNum % 10;
                    //създава се текуща цифра 4
                    currNum = currNum / 10;
                    //числото става 12346 - т.е. позициите стават 5 - нечетно
                    //aко след като числото е станало четно
                    if (position % 2 == 0)
                        evenSum += currDigit;
                    else
                        oddSum += currDigit;
                    position--;
                }
                if (evenSum == oddSum)
                    Console.Write($"{counter} ");
            }
        }
    }
}
