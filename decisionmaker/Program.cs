using System;

namespace decisionmaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string again = "y";
            while(again == "y")
            {
                Console.Write("What was your score percentage? ");
                float percentage = float.Parse(Console.ReadLine());
                string lettergrade = "F";

                if(percentage >= 90)
                {
                    lettergrade = "A";
                }
                else if(percentage >= 80)
                {
                    lettergrade = "B";
                }
                else if(percentage >= 70)
                {
                    lettergrade = "C";
                }
                else if(percentage >= 60)
                {
                    lettergrade = "D";
                }
                else if(percentage >= 50)
                {
                    lettergrade = "E";
                }
                else
                {
                    lettergrade = "F";
                }
                Console.WriteLine($"Your grade is {lettergrade}");
                Console.WriteLine("Would you like to grade another? (y/n)");
                again = Console.ReadLine();
            }
        }
    }
}
