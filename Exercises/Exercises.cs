using Microsoft.VisualBasic;

namespace Exercises
{
    internal class Exercises
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or 9 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;


                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RuneExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 9:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;

                    }
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
        } // End of main


        private static void RunExerciseOne()
        {
            string firstName = "Erik";
            string lastName = "Christensson";
            Console.WriteLine($"Hello {firstName} {lastName}! I'm glad to inform you that you are the test subject of my very first assignment!");
        }


        private static void RunExerciseTwo()
        {
            DateTime todaysDate = DateTime.Today;
            DateTime tomorrowsDate = DateTime.Today.AddDays(1);
            DateTime yesterdaysDate = DateTime.Today.AddDays(-1);

            Console.Write($"Todays date is {todaysDate}\nTomorrows date is {tomorrowsDate}\nYesterdays date was {yesterdaysDate}\n");
        }


        private static void RuneExerciseThree()
        {
            Console.Write("Enter your first name: ");
            string? firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string? lastName = Console.ReadLine();
            Console.WriteLine($"{firstName} {lastName}");
        }


        private static void RunExerciseFour()
        {
            string str = "The quick fox Jumped Over the DOG";
            string newStr = str.Replace(str, "The brown fox jumped over the lazy dog");
            Console.WriteLine(newStr);
        }
    }
}