namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade");
        string gradeInput = Console.ReadLine();
        int gradePoint = -1;
        switch (gradeInput)
        {
            case "A":
                gradePoint = 4;
                break;
            case "B":
                gradePoint = 3;
                break;
            case "C":
                gradePoint = 2;
                break;
            case "D":
                gradePoint = 1;
                break;
            case "F":
                gradePoint = 0;
                break;
            default:
                gradePoint = -1;
                break;
        }

        if(gradePoint == -1)
        {
            Console.WriteLine("Wrong Letter Grade!");
        } else {
            Console.WriteLine($"GPA point: {gradePoint}");
        }

        // end of GPA score
        Console.WriteLine("Please input the first num");
        int firstNum = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the second num");
        int secondNum = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the third num");
        int thirdNum = Convert.ToInt16(Console.ReadLine());

        int x = compareTwoIntegers(firstNum, secondNum);
        Console.WriteLine($"The smallest value is: {compareTwoIntegers(x, thirdNum)}");

        // end of compare three numbers

        Console.WriteLine("Please input a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if(year % 400 == 0)
        {
            Console.WriteLine($"{year} is a Leap Year");

        } else if (year % 4 == 0 && year % 100 != 0) {
            Console.WriteLine($"{year} is a Leap Year");

        } else {
            Console.WriteLine($"{year} is not a Leap Year");
        }
    }

    static int compareTwoIntegers(int x, int y)
    {
        if (x < y)
        {
            return x;
        } else {
            return y;
        }
    }
}
