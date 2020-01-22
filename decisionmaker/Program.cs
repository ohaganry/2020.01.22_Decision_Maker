using System;

namespace decisionmaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            bool end = false;
            while(end == false)
            {
                int userInput;
               
                Console.WriteLine("Give me a whole number between 1 and 100");
                userInput = int.Parse(Console.ReadLine());

                while(userInput > 0 && userInput <= 100)
                {

                    string status = EvenOrOdd(userInput);

                    if(status == "odd")
                    {
                        Console.WriteLine($"{name}, your number, {userInput}, is {status}");
                    }
                    else
                    {
                        if(userInput >= 2 && userInput <= 25)
                        {
                            Console.WriteLine($"{name}, your number is {status} and less than 25");
                        }
                        else if(userInput > 25 && userInput <= 65)
                        {
                            Console.WriteLine($"{name}, your number is {status}");
                        }
                        else
                        {
                            Console.WriteLine($"{name}, your number, {userInput}, is {status}");
                        }
                    }
                    userInput = 0;
                }
                 Console.WriteLine("Would you like to try again (y/n)?");
                    while(Console.ReadLine() == "n")
                    {
                        end = true;
                        Console.WriteLine($"Thank you {name}. Goodbye");
                        return;
                    }
            }

        }
        public static string EvenOrOdd(int num1)
        {
            int remainder = num1 % 2;
            string result;
            if(remainder == 0)
            {
                result = "even";
            }
            else
            {
                result = "odd";
            }
            return result;
        }
    }
}
