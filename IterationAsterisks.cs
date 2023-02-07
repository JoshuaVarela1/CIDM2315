using System;

public class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        string output = "";

        for (int i = 0; i< num; i++)
        {
            output += '*';
            Console.WriteLine(output);
        }
    }
}
