namespace test;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter Your Name:");
        string userName = Console.ReadLine();
            
        Console.WriteLine("Please Enter Your Age:");
        int userAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Please Enter Your Salary:");
        float usersalary = float.Parse(Console.ReadLine());
        
    }
}