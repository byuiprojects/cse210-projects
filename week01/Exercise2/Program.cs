using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage (0-100): ");
        string score = Console.ReadLine();
        int grade = int.Parse(score);
        if
        (grade >= 90)
        {
            Console.WriteLine("You got an A!");
        }
        else
        {
            if (grade >= 80)
            {
                Console.WriteLine("You got a B!");
            }
            else
            {
                if (grade >= 70)
                {
                    Console.WriteLine("You got a C!");
                }
                else
                {
                    if (grade >= 60)
                    {
                        Console.WriteLine("You got a D!");
                    }
                    else
                    {
                        Console.WriteLine("You got an F!");
                    }
                }
        }
    Console.WriteLine("Thank you for using the grade calculator.");
        }
    }
        

