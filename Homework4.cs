using System;

public class Program
{

    static void comparer()
    {
        int x, y;
        Console.WriteLine("Please input two integers to be compared: ");

        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        
        if(x > y)
        {
            Console.WriteLine(x + " is the greater number");
        } else if (x < y)
        {
            Console.WriteLine(y + " is the greater number");
        } else if (x == y)
        {
            Console.WriteLine("Both number are equal");
        }
    }

    static void shapeGenerator()
    {
        bool isLeft = false;

        // read inputs
        Console.WriteLine("Input integer to print shape: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input direction ('Left' or 'Right'): ");
        string direction = Console.ReadLine();
        direction = direction.ToUpper(); // uppercase the input for better UI


        // Read the direction
        if(direction != "LEFT" && direction != "RIGHT") // ensure correct input
        {
            Console.WriteLine("Not a valid input, please input \"LEFT\" or \"RIGHT\" ");
            num = -1; // do not excute the pattern
        } 
        else if (direction == "LEFT")
        {
            isLeft = true;
        }
        else
        {
            isLeft = false;
        }

        // print triangle pattern
        for (int i = 0; i <= num; i++)
         {
            for (int j = 1; j <= num-i && isLeft; j++)
            {  
               Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {  
               Console.Write("*");
            }
            Console.WriteLine("");
         }
    }
    static void Main(string[] args)
    {
        comparer();
        shapeGenerator();
    }
}
