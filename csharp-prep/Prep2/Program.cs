using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

   Console.Write("Please input your grade ");
    string grade = Console.ReadLine();
    int number = int.Parse(grade);
    string letter ="";

    if (number >= 90)
{
    letter="A";
    
}
else if (number >= 80)
{
    letter="B";
    
}
else if (number >= 70 )
{
    letter="C";
    
}
else if (number>= 60 )
{
    letter="D";
    
}
else 
{
    letter="F";
    
}
Console.WriteLine($"Your grade is: {letter}");
if (number > 70)
{
Console.WriteLine("Congratulations! You have passed this test");
}
else
{
Console.WriteLine("Sorry, You can take the test again.");
}






    }
}