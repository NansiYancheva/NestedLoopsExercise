using System;
namespace NestedLoopsExercise
{
    class Program
    {
        static void Main()
        {
        int number = int.Parse(Console.ReadLine());
            int currNum = 1;
            //редове
            for (int row = 1; row <= number; row++)
            {
                //на всеки ред какво
                for (int col = 1; col <= row; col++)
                {
                    if (currNum > number)
                    {
                        break;
                    }
                    Console.Write(currNum + " ");
                    currNum++;
                }
                if (currNum > number)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}

