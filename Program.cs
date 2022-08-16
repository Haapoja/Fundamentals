// ******* VARIABLE FUNDAMENTALS *******

//int x;
//int y;

//x = 7;
//y = x + 3;

//Console.WriteLine(y);
//Console.ReadLine();

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Who are you?");
//        Console.Write("Enter first name: ");
//        string firstName;
//        firstName = Console.ReadLine();

//        //string lastName;
//        //Console.Write("Enter last name: ");
//        //lastName = Console.ReadLine();

//        Console.WriteLine("Enter last name: ");
//        string lastName = Console.ReadLine();

//        Console.WriteLine("Hello, " + firstName + " " + lastName);
//    }
//}


// ******* IF STATEMENT FUNDAMENTALS *******
/*
internal class IF_statement
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Bobby's Big Giveaway");
        //Console.Write("Choose a door: 1, 2 or 3: ");
        //string userValue = Console.ReadLine();
        //string message = "";
        //// "==" = evalution for true or false, like python
        ////in if else statements, if there is only one line of code to execute, {} braces are not needed
        //if (userValue == "1")
        //    message = "You won a toaster";
        //else if (userValue == "2")
        //    message = "You won 2 dolla";
        //else if (userValue == "3")
        //    message = "You won a keychain!";
        //else
        //{
        //    message = "You won nothing";
        //    message += "Get out. Now.";
        //}
            
        //Console.WriteLine(message);
        //Console.ReadLine();



        Console.WriteLine("Bobby's Big Giveaway");
        Console.Write("Choose a door: 1, 2 or 3: ");
        string userValue = Console.ReadLine();
        //if value = 1, boat is stored in message, else, stand of lint
        string message = (userValue == "1") ? "boat" : "strand of lint";
        //Console.Write("You won a ");
        //Console.Write(message);
        //Console.Write(".");
        //pythons f string is better
        //Console.WriteLine("You won a {0}.", message);
        Console.WriteLine("You entered {0}. You won a {1}.", userValue, message);
        Console.ReadLine();
    }
}
*/
// ******* Operators, Expressions Statements *******

//internal class Operators
//{
//    private static void Main(string[] args)
//    {
//        int x, y, a, b;
//        x = 3;
//        y = 5;
//        a = 6;
//        b = 1;

//        //addition operator
//        x = 3 + 2;
//        //Subtraction operator 
//        x = 5 - 2;
//        //multiplication operator
//        x = 2 * 2;
//        //Division operator 
//        x = 6 / 2;
//        //Order of operations
//        x = (x + y) * (b - a);

//        // Equality operator
//        if (x == y)
//        {

//        }
//        // grater than operator
//        if (x > y)
//        {

//        }
//        //less than operator
//        if (x < y)
//        {

//        }
//        //Greater or equal to operator
//        if (x <= y)
//        {

//        }
//        //Conditional OR operator
//        if ((x > y) || (a > b))
//        {

//        }
//        //Conditional AND operator
//        if ((x > y) && (a > b))
//        {

//        }
//        //inline conditional operator
//        string message = (x == 1) ? "Yes" : "No";
//    }
//}

// ******* For Iteration *******

//internal class ForIteration
//{
//    static void Main(string[] args)
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            //Console.WriteLine(i);
//            if (i == 7)
//            {
//                Console.WriteLine("found seven");
//                break;
//            }


//        }


//        Console.ReadLine();

//    }
//}

// ******* Arrays *******

//internal class Arrays
//{
//    static void Main(string[] args)
//    {                   //new int[Num] num specify the the amount of items in the array
//        //int[] numbers = new int[5];

//        //numbers[0] = 4;
//        //numbers[1] = 8;
//        //numbers[2] = 15;
//        //numbers[3] = 18;
//        //numbers[4] = 23;
//        //numbers[5] = 24; //index out of range

//        //Console.WriteLine(numbers[2]);
//        //Console.WriteLine(numbers.Length);
//        //Console.ReadLine();

//        //int[] numbers = new int[] { 5, 7, 8, 9, 10, 12 };
//        //string[] names = new string[] { "Bobby", "billy", "billy-bob", "Bobenheimer" };

//        //for (int i = 0; i < names.Length; i++)
//        //{
//        //    Console.WriteLine(names[i]);

//        //}
//        //Console.ReadLine();
//        //foreach (string name in names)
//        //{
//        //    Console.WriteLine(name);
//        //}
//        //Console.ReadLine();
//        //Reverse string with array
//        string quote = "I live in a constant state of fear and misery";
//        char[] charArray = quote.ToCharArray();
//        Array.Reverse(charArray);

//        foreach (char quoteChar in charArray)
//        {
//            Console.Write(quoteChar);
//        }
//        Console.ReadLine();
//    }
//}


// ******* Defining and calling methods *******

//class Method
//{
//    static void Main()
//    {
//        HelloWorld();
//        Console.ReadLine();

//    }

//    private static void HelloWorld()
//    {
//        Console.WriteLine("Hello world");
//    }
//}

class Methods
{
    static void Main()
    {
        Console.WriteLine("Name game");
       
        Console.Write("Whats your name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.Write("In what city were you born? ");
        string city = Console.ReadLine();
        /*
       char[] firstNameArray = firstName.ToCharArray();
       Array.Reverse(firstNameArray);

       char[] lastNameArray = lastName.ToCharArray();
       Array.Reverse(lastNameArray);

       char[] cityArray = city.ToCharArray();
       Array.Reverse(cityArray);

       string result = "";

       foreach (char item in firstNameArray)
       {
           result += item;
       }
       result += " ";

       foreach (char item in lastNameArray)
       {
           result += item;
       }
       result += " ";

       foreach (char item in cityArray)
       {
           result += item;
       }

       Console.WriteLine("Results: " + result);


       */
        
        
       DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

       Console.ReadLine();
    }
    private static string ReverseString(string message)
    {
        
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);
        return String.Concat(messageArray);
    
    }
    private static void DisplayResult(string reversedFirstName, string reversedLasttName, string reversedCity)
    {
        Console.Write("Results: ");
        Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reversedLasttName, reversedCity));
    }
}