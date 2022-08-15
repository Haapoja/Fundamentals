// ******* VARIABLE FUNDAMENTALS *******

//int x;
//int y;

//x = 7;
//y = x + 3;

//Console.WriteLine(y);
//Console.ReadLine();

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Who are you?");
        Console.Write("Enter first name: ");
        string firstName;
        firstName = Console.ReadLine();

        //string lastName;
        //Console.Write("Enter last name: ");
        //lastName = Console.ReadLine();

        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Hello, " + firstName + " " + lastName);
    }
}


