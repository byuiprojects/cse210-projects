using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your  first name?");
        string FirstName = Console.ReadLine();
        Console.WriteLine("what is your last name?");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName},{FirstName} {lastName} ");
    
}
}