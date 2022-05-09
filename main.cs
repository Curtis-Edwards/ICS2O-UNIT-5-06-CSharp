using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int integer1;
        int integer2;
        var answer = 0;
        var counter = 0;

        Console.WriteLine("Please enter your integers");
        Console.WriteLine("");

        Console.Write("Integer 1: ");
        integer1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Integer 2: ");
        integer2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if (integer1 > 0 && integer2 > 0)
        {
            while (counter < integer2)
            {
                answer = answer + integer1;
                counter = counter + 1;
            }
        }
        else if (integer1 > 0 && integer2 < 0)
        {
            while (counter > integer2)
            {
                answer = answer - integer1;
                counter = counter - 1;
            }
        }
        else if (integer1 < 0 && integer2 > 0)
        {
            while (counter > integer1)
            {
                answer = answer - integer2;
                counter = counter - 1;
            }
        }
        else if (integer2 < 0 && integer1 < 0)
        {
            while (counter > integer2)
            {
                answer = answer - integer1;
                counter = counter - 1;
            }
        }
        Console.WriteLine(answer);

        Console.WriteLine("\nDone.");
    }
}