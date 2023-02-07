using System;

public class Program
{
    static void Main(string[] args)
    {
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
}