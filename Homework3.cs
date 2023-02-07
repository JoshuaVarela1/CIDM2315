using System;

public class Program
{
    static void PrimeNumber()
    {

    Console.WriteLine("Input an integer to check for prime");
        int input = Convert.ToInt32(Console.ReadLine());

        int result = -9;

        for (int i = 2; i < input; i++) 
        {

          result = input % i;

            if(result == 0)
            {
               break;
            }
        }

        if(result == 0) {
            Console.WriteLine(input + " is non-prime");
        } else {
            Console.WriteLine(input + " is prime");
        }
    }

    static void SquarePattern() 
    {
        Console.WriteLine("Input an Integer for Squares pattern");
        int num = Convert.ToInt32(Console.ReadLine());

        string outputSquares = "";

        for (int i =0; i<num; i++)
        {
            outputSquares += '#';
        }
        for(int i =0; i<num; i++)
        {
            Console.WriteLine(outputSquares);
        }
    }

    static void AsterisksPattern()
    {
        Console.WriteLine("Input an Integer for asterisk pattern");
        int num = Convert.ToInt32(Console.ReadLine());

        string output = "";

        for (int i = 0; i< num; i++)
        {
            output += '*';
            Console.WriteLine(output);
        }
    }
    static void Main(string[] args)
    {
        PrimeNumber();
        SquarePattern();
        AsterisksPattern();
    }
}
