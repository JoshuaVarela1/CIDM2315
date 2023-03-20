namespace Homework7;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("creating Customer Record\n");

        Customer cus_alice = new Customer(110, "Alice", 28);
        Customer cus_bob = new Customer(111, "Bob", 30);

        cus_alice.PrintCusInfo();
        cus_bob.PrintCusInfo();

        cus_alice.ChangeID(220);
        cus_bob.ChangeID(221);

        cus_alice.PrintCusInfo();
        cus_bob.PrintCusInfo();

        cus_alice.CompareAge(cus_bob);
    }
}

class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer)
    {
        if(cus_age > objCustomer.cus_age)
        {
            Console.WriteLine(cus_name + " is older");
        }
        else
        {
            Console.WriteLine(objCustomer.cus_name + " is older");
        }
    }
}
