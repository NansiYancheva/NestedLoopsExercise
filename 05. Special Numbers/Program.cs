using System;
namespace NestedLoopsExercise
{
    class Program
    {
        static void Main()
        {
            //Входът се чете от конзолата и се състои от едно цяло число в интервала [1…600000]
            int number = int.Parse(Console.ReadLine());
            //Actions

            for (int diapason = 1111; diapason <= 9999; diapason++)
            {
                bool isSpecial = true;
                while (diapason <= 9999)
                {
                    //взимаме текущата цифра
                    int currDigit = diapason % 10;
                    diapason = diapason / 10;
                    if (number % currDigit == 0)
                    {
                        isSpecial = true;
                        continue;
                    }
                    if (isSpecial)
                        Console.Write($"{diapason} ");

                }
             }
        }
    }
}