using Microsoft.VisualBasic;
using System.Diagnostics.SymbolStore;
using System.Text.Json;

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
                    Console.Write("Enter assignment number (or -1 to exit): ");
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
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 11:
                            RunExerciseEleven();
                            break;
                        case 12:
                            RunExerciseTwelve();
                            break;
                        case 13:
                            RunExerciseThirteen();
                            break;
                        case 14:
                            RuneExercisefourteen();
                            break;
                        case 15:
                            RuneExerciseFifteen();
                            break;
                        case 16:
                            RunExerciseSixteen();
                            break;
                        case 17:
                            RunExerciseSeventeen();
                            break;
                        case 18:
                            RunExerciseEighteen();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
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
            string newStr = str.ToLower();
            newStr = char.ToUpper(newStr[0]) + newStr.Substring(1);
            newStr = newStr.Replace("quick", "brown").Insert(newStr.IndexOf("the") + 3, " lazy");
            Console.WriteLine(newStr);
        }


        private static void RunExerciseFive()
        {
            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            string newStr = str.Substring(str.IndexOf("["));
            newStr = newStr.Remove(newStr.IndexOf('2'), 4);
            newStr = newStr.Insert(newStr.IndexOf("5") + 1, ",6,7,8,9,10");
            Console.WriteLine(newStr);
        }


        private static void RunExerciseSix()
        {
            Console.Write("Input first integer: ");
            double num1, num2;
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Input second integer: ");
            double.TryParse(Console.ReadLine(), out num2);

            double minNum = Math.Min(num1, num2);
            double maxNum = Math.Max(num1, num2);
            double diff = Math.Abs(num1 - num2);
            double sum = num1 + num2;
            double prod = num1 * num2;
            double ratio = num1 / num2;

            Console.WriteLine($"Smallest: {minNum}\nLargest: {maxNum}\nDifference: {diff}\nSum: {sum}\nProduct: {prod}\nRatio: {ratio}");
        }


        private static void RunExerciseSeven()
        {
            Console.Write("Input radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = 2 * Math.Pow(radius, 2) * Math.PI;
            double volume = (4 * Math.Pow(radius, 3) * Math.PI) / 3;
            Console.WriteLine($"Circle area: {area}\nCircle volume: {volume}");
        }


        private static void RunExerciseEight()
        {
            Console.Write("Input number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Square root: {Math.Sqrt(num)}\nSecond power: {Math.Pow(num, 2)}\nTenth power: {Math.Pow(num, 10)}");
        }


        private static void RunExerciseNine()
        {
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}, what is your birth year? ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int age = DateTime.Now.Year - birthYear;


            if (age >= 18)
            {
                Console.WriteLine("Do you want a beer?");
                string? answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Your order has been placed!");
                }
                else
                {
                    Console.WriteLine("Do you want a coke? ");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        Console.WriteLine("Your order has been placed!");
                    } else
                    {
                        Console.WriteLine("There are no other options!");
                    }
                }
            } else
            {
                Console.WriteLine("Do you want a coke? ");
                string? answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    Console.WriteLine("Your order has been placed!");
                }
                else
                {
                    Console.WriteLine("There are no other options!");
                }
            }

        }


        private static void RunExerciseEleven()
        {
            Console.Write("Enter a number greater than zero: ");
            int input = Convert.ToInt32(Console.ReadLine());


            if (input < 0)
            {
                Console.Write("Number needs to be greater than zero!");
            }


            for (int i = 0; i <= input; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine("----------------------------------");


            for (int i = input; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                }
            }
        }


        private static void RunExerciseTwelve()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }


        private static void RunExerciseThirteen()
        {
            Random rand = new Random();
            int number = rand.Next(1, 501);
            bool correctGuess = false;


            while (!correctGuess)
            {
                Console.Write("Guess a number: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("Correct guess");
                    correctGuess = true;
                } else if (guess < number)
                {
                    Console.WriteLine("Your guess was too small!");
                } else
                {
                    Console.WriteLine("Your guess was to large!");
                }
            }

        }


        private static void RuneExercisefourteen()
        {
            bool keepLooping = true;
            double sum = 0;
            double count = 0;
            double avg = 0;
            
            while (keepLooping)
            {
                Console.Write("Enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1) 
                {
                    keepLooping = false;
                    break;
                }
                
                sum += input;
                count++;
                avg = sum / count;
            }
            Console.WriteLine($"Sum: {sum}\nAvg: {avg}");
        }


        private static void RuneExerciseFifteen()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{i} ");
                }
            }



        }


        private static void RunExerciseSixteen()
        {
            Console.Write("Enter a nubmer: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int fib1 = 0;
            int fib2 = 1;
            int fibN;

            Console.WriteLine(fib1);
            Console.WriteLine(fib2);

            for (int i = 0; i < inputNum - 2; i++)
            {
                fibN = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibN;
                Console.WriteLine(fibN);
            }
        }


        private static void RunExerciseSeventeen()
        {
            Console.Write("Enter a word to check: ");
            string? word = Console.ReadLine();
            word = word.Replace(" ", "").ToLower();
            string temp = "";
            

            for (int i = word.Length - 1; i >= 0; i--)
            {
                temp += word[i];
            }

            if (temp == word)
            {
                Console.WriteLine($"\"{word}\" is a palindrome");
            } else
            {
                Console.WriteLine($"\"{word}\" is not a palindrome");
            }
        }


        private static void RunExerciseEighteen()
        {
            int[] arr = new int[10];
            double[] arr2 = new double[10];
            Random random = new Random();

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = random.Next(1, 101);
                arr2[i] = 1 / Convert.ToDouble(arr[i]);
            }
            
            
            foreach (int item in arr ) 
            {
                Console.WriteLine(item);
            } 


            foreach (double item in arr2)
            {
                Console.WriteLine(item);
            }
        }


        private static void RunExerciseNineteen()
        {
            int[] moneyDenominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            int amountToPay = 500;
            
            
            Console.WriteLine($"Money to pay: {amountToPay}");
            Console.Write("Enter the sum to pay: ");
            int givenMoney = Convert.ToInt32(Console.ReadLine());


            int change = givenMoney - amountToPay;
            for (int i = 0; i <= moneyDenominations.Length; i++)
            {
                if (change >= moneyDenominations[i])
                {
                    Console.WriteLine(moneyDenominations[i]);
                }
            }


        }
    } // End of namespace
}