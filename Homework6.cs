namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        // Generate two professors
        Console.WriteLine("\nGenerating Professor Records...");

        Professor alice = new Professor("Alice", "Java", 9000);
        Professor bob = new Professor("Bob", "Math", 8000);


        // Generate two students
        Console.WriteLine("\nGenerating Student Records...");
        
        Student lisa = new Student("Lisa", "Java", 90);
        Student tom = new Student("Tom", "Math", 80);

        Console.WriteLine("\nPrinting Professor Records...");

        Console.WriteLine("Professor " + alice.getName() + " teaches " + alice.getClass()  
                            + ", and the salary is: " + alice.getSalary());

        Console.WriteLine("Professor " + bob.getName() + " teaches " + bob.getClass()  
                            + ", and the salary is: " + bob.getSalary());

        Console.WriteLine("\nPrinting Student Records...");

        Console.WriteLine("Student " + tom.getName() + " enrolls " + tom.getClass() 
                            + ", and the grade is: " + tom.getGrade());
        Console.WriteLine("Student " + lisa.getName() + " enrolls " + lisa.getClass() 
                            + ", and the grade is: " + lisa.getGrade());

        Console.WriteLine("The salary difference between " + alice.getName() + " and " + bob.getName() + " is: " + (alice.getSalary() - bob.getSalary()));

        Console.WriteLine("The total grade of " + lisa.getName() + " and " + tom.getName() + " is: " + (lisa.getGrade() + tom.getGrade()));
    }
}
class Professor
{
    // Declare Variables
    private string profName;
    private string classTeach;
    private double salary;

    // Constructor
    public Professor(string name, string course, double wage)
    {
        this.profName = name;
        this.classTeach = course;
        this.salary = wage;
    }

    // Set function
    public void setSalary(double salary_amount)
    {
        this.salary = salary_amount;
    }

    // Get functions
    public string getName()
    {
        return this.profName;
    }

    public string getClass()
    {
        return this.classTeach;
    }

    public double getSalary()
    {
        return this.salary;
    }
}

class Student
{
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    public Student(string name, string course, double grade)
    {
        this.studentName = name;
        this.classEnroll = course;
        this.studentGrade = grade;
    }

    // Set function
    public void setGrade(double newGrade)
    {
        this.studentGrade = newGrade;
    }

    // Get functions
    public string getName()
    {
        return this.studentName;
    }

    public string getClass()
    {
        return this.classEnroll;
    }

    public double getGrade()
    {
        return this.studentGrade;
    }
}
