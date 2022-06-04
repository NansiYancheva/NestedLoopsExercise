using System;
namespace NestedLoopsExercise
{
    class Program
    {
        static void Main()
        {
            int numberTeachers = int.Parse(Console.ReadLine());
            string nameOfTask;
            double endResultCurrTasks = 0;
            int numberOfTasks = 0;
            double endResultAllTasks = 0;

            while ((nameOfTask = Console.ReadLine()) != "Finish")
            {
                numberOfTasks++;
                double resultTask = 0;

                for (int i = 0; i < numberTeachers; i++)
                {
                    double resultTeacher = double.Parse(Console.ReadLine());
                    resultTask += resultTeacher;
                    endResultAllTasks += resultTeacher;
                }
                endResultCurrTasks = resultTask / numberTeachers;
                Console.WriteLine($"{nameOfTask} - {endResultCurrTasks:f2}.");
            }
            int division = numberOfTasks * numberTeachers;
            double finalAssessment = endResultAllTasks / division;
            Console.WriteLine($"Student's final assessment is {finalAssessment:f2}.");
            return;
        }
    }
}

