using System;

public class Program
{
    public static void Main(string[] args)
    {
        var fizzBuzz = new FizzBuzzChallenge();

        Console.WriteLine("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine(fizzBuzz.FizzBuzz(number));
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}

public class FizzBuzzChallenge
{
    public string FizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
            return "fizzbuzz";

        if (number % 3 == 0)
            return "fizz";

        if (number % 5 == 0)
            return "buzz";

        return number.ToString();
    }
}
