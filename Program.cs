using System;

public class BasicMath
{
    public static void Main(string[] args)
    {
        char[] valid = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        int loc = 0;
        //These are here so the code can check if the potential numbers entered are, in fact, numbers

        Console.WriteLine("Select an operation:\nAddition (add)\nSubtraction (sub)\nMultiplication (mult)\nDivision (div)\nModulus (mod)");
        string operation = Console.ReadLine();

        while (!operation.ToLower().Equals("add") && !operation.ToLower().Equals("sub") && !operation.ToLower().Equals("mult") && !operation.ToLower().Equals("div")
              && !operation.ToLower().Equals("mod"))
        {
            Console.WriteLine("\nEnter \"add\", \"sub\", \"mult\", \"div\", or \"mod\"");
            operation = Console.ReadLine();
        }


        Console.Write("\nEnter first number: ");
        string numStr1 = Console.ReadLine();

        foreach (char c in numStr1)
        {
            for (loc = 0; loc < valid.Length; loc++)
                if (c.Equals(valid[loc]))
                    break;
        }
        while (loc == valid.Length)
        {
            Console.WriteLine("\nInvalid input. Try again.");

            numStr1 = Console.ReadLine();
            foreach (char c in numStr1)
            {
                for (loc = 0; loc < valid.Length; loc++)
                    if (c.Equals(valid[loc]))
                        break;
            }
        }
        /*Forgot how to make for loops for a minute and had to google it
        foreach acts similar in terms of iteration through something but it goes through everything and you can't track the location*/

        int num1 = int.Parse(numStr1);


        Console.Write("\nEnter second number: ");
        string numStr2 = Console.ReadLine();

        foreach (char c in numStr2)
        {
            for (loc = 0; loc < valid.Length; loc++)
                if (c.Equals(valid[loc]))
                    break;
        }
        while (loc == valid.Length)
        {
            Console.WriteLine("\nInvalid input. Try again.");
            
            numStr2 = Console.ReadLine();
            foreach (char c in numStr2)
            {
                for (loc = 0; loc < valid.Length; loc++)
                    if (c.Equals(valid[loc]))
                        break;
            }
        }

        int num2 = int.Parse(numStr2);


        if (operation.ToLower().Equals("add"))
            Console.WriteLine("\n" + num1 + " + " + num2 + " = " + (num1 + num2));
        else if (operation.ToLower().Equals("sub"))
            Console.WriteLine("\n" + num1 + " - " + num2 + " = " + (num1 - num2));
        else if (operation.ToLower().Equals("mult"))
            Console.WriteLine("\n" + num1 + " * " + num2 + " = " + (num1 * num2));
        else if (operation.ToLower().Equals("div"))
        {
            string divide = "";
            if (num1 % num2 != 0)
            {
                Console.WriteLine("\nDo you want to perform decimal division? (yes/no)");
                divide = Console.ReadLine();

                while (!divide.ToLower().Equals("yes") && !divide.ToLower().Equals("no"))
                {
                    Console.WriteLine("\nEnter \"yes\" or \"no\"");
                    divide = Console.ReadLine();
                }
            }

            if (divide.ToLower().Equals("yes"))
                Console.WriteLine("\n" + num1 + " / " + num2 + " = " + (double.Parse(numStr1) / num2));
            else
                Console.WriteLine("\n" + num1 + " / " + num2 + " = " + (num1 / num2));
        }
        else
            Console.WriteLine("\n" + num1 + " % " + num2 + " = " + (num1 % num2));
    }
}