using System;

public class BasicMath
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Select an operation:\nAddition (add)\nSubtraction (sub)\nMultiplication (mult)\nDivision (div)\nModulus (abs)");
        string operation = Console.ReadLine();

        while(!operation.ToLower().Equals("add") && !operation.ToLower().Equals("sub") && !operation.ToLower().Equals("mult") && !operation.ToLower().Equals("div")
              && !operation.ToLower().Equals("abs"))
        {
            Console.WriteLine("\nEnter \"add\", \"sub\", \"mult\", \"div\", or \"abs\"");
            operation = Console.ReadLine();
        }

        Console.Write("\nEnter first number: ");
        string numStr1 = Console.ReadLine();

        Console.Write("\nEnter second number: ");
        string numStr2 = Console.ReadLine();

        if(operation.ToLower().Equals("add"))
        {}
        else if(operation.ToLower().Equals("sub"))
        {}
        else if(operation.ToLower().Equals("mult"))
        {}
        else if(operation.ToLower().Equals("div"))
        {}
        else
        {}
    }
}