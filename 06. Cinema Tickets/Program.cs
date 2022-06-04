using System;
namespace NestedLoopsExercise
{
    class Program
    {
        static void Main()
        {
            string nameOfMovie;
            string ticketType;
            double studentTickets = 0;
            double standardTickets = 0;
            double kidTickets = 0;
            double percentTakenTickets = 0;
            double ticketsFromAllMovies = 0;

            while ((nameOfMovie = Console.ReadLine()) != "Finish")
            {
                double freePlaces = double.Parse(Console.ReadLine());
                double totalNumberTickets = 0;
                while ((ticketType = Console.ReadLine()) != "End")
                {
                    ticketsFromAllMovies++;
                    totalNumberTickets++;
                    if (ticketType == "student")
                        studentTickets++;
                    else if (ticketType == "standard")
                        standardTickets++;
                    else if (ticketType == "kid")
                        kidTickets++;
                    if (totalNumberTickets == freePlaces)
                        break;
                }
                //Общо 6 билета от 10 места -> 60% от залата е заета.
                percentTakenTickets = totalNumberTickets / freePlaces * 100;
                //След всеки филм да се отпечата, колко процента от кино залата е пълна
                if (totalNumberTickets == freePlaces)
                {
                    Console.WriteLine($"{nameOfMovie} - 100.00% full.");
                }
                else
                Console.WriteLine($"{nameOfMovie} - {percentTakenTickets:f2}% full.");


            }
            //При получаване на командата "Finish" да се отпечатат четири реда:
            //"Total tickets: {общият брой закупени билети за всички филми}"
            Console.WriteLine($"Total tickets: {ticketsFromAllMovies}");
            //"{процент на студентските билети}% student tickets."
            double percStudentTickets = (studentTickets / ticketsFromAllMovies) * 100;
            Console.WriteLine($"{percStudentTickets:f2}% student tickets.");
            //"{процент на стандартните билети}% standard tickets."
            double percStandartTickets = (standardTickets / ticketsFromAllMovies) * 100;
            Console.WriteLine($"{percStandartTickets:f2}% standard tickets.");
            //"{процент на детските билети}% kids tickets."
            double perckidsTickets = (kidTickets / ticketsFromAllMovies) * 100;
            Console.WriteLine($"{perckidsTickets:f2}% kids tickets.");

        }
    }
}
