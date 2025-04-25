using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("what is your first name? ");
        string first_name = Console.ReadLine(); 
        Console.Write("what is your Last name? ");
        string Last_name = Console.ReadLine(); 

        Console.WriteLine($"Your name is {Last_name}, {first_name} {Last_name}. ");
    }
}