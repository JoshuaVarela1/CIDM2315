namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        int w = readInt("Input your first number to be compared");
        int x = readInt("Input your second number to be compared");
        int y = readInt("Input your third number to be compared");
        int z = readInt("Input your fourth number to be compared");

        Console.WriteLine(compareFourIntegers(w, x, y, z) + " is the largest number \n\n\n");

        Console.WriteLine("Creating your account...");
        createAccount();
    }
/*
 *
 * Tool method
 *
 */

    // Output string and input integer
    static int readInt(string output)
    {
        Console.WriteLine(output);
        int returnInt = Convert.ToInt32(Console.ReadLine());
        return returnInt;
    }

    // Output string and input string
    static string readString(string output)
    {
        Console.WriteLine(output);

        string returnString = Console.ReadLine();

        return returnString;
    }

    /*
     *
     * Comparsion functions
     *
     */

    static int compareTwoIntegers(int x, int y)
    {
        if (x > y)
        {
            return x;
        } else {
            return y;
        }
    }

    static int compareFourIntegers(int w, int x, int y, int z)
    {
        int max1 = compareTwoIntegers(w, x);
        int max2 = compareTwoIntegers(y, z);

        if(max1 > max2)
        {
            return max1;
        } else {
            return max2;
        }
    }

    /*
     *
     * Account Functions
     *
     */

    static bool checkAge(int birth_year)
    {
        int age = 2023 - birth_year; // 2023 is purposely used
        if(age < 18)
        {
            return false;
        } else {
            return true;
        }
    }

    static void createAccount() 
    {
        string username = readString("Input an username");
        string password = readString("Input your password");
        string password2 = readString("Input your password again");

        int birthYear = readInt("Input your birth year eg 2023");

        if(checkAge(birthYear) == true)
        {
            if(password == password2)
            {
                Console.WriteLine("Account successfully created!");
            } else {
                Console.WriteLine("Incorrect password");
            }
        } else {
            Console.WriteLine("Could not create an account");
        }
    }
}
