namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
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
    }
}
