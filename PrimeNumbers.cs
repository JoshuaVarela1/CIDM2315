namespace PrimeNumbers;
class Program
{
    static void Main(string[] args)
    {
        int breakWhile = 0;
        Console.WriteLine("-1 to end program");

        while(breakWhile != -1)
        {
            Console.WriteLine("Input an integer");

            int input = Convert.ToInt32(Console.ReadLine());

            breakWhile = input;

            if(breakWhile == -1)
            {
                break;
            }

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
    }
}
