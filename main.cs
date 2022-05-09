using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int radius;
        double pi = Math.PI;
        double area;

        Console.WriteLine("Please enter the radius of the circle");
        Console.WriteLine("");

        Console.Write("radius: ");
        radius = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        area = (pi * radius) * radius;

        Console.WriteLine("Area: " + area.ToString("0.00") + "cm²");

        Console.WriteLine("\nDone.");
    }
}