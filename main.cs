// Created by: Marshall Demars
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program tells you the type of triangle
        double lengthOne;
        double lengthTwo;
        double lengthThree;

        // input
        Console.WriteLine("This program tells you the type of triangle");
        Console.WriteLine("");
        Console.WriteLine("You will need to input the three lengths of the triangle");
        Console.WriteLine("");
        Console.WriteLine("Please input the first length (cm)");
        lengthOne = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Please input the second length (cm):");
        lengthTwo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Please input the third length (cm):");
        lengthThree = Convert.ToDouble(Console.ReadLine());

        // process
        Console.WriteLine("");
       if ((lengthOne <= 0) || (lengthTwo <= 0) || (lengthThree <= 0))
        {
            Console.WriteLine("");
            Console.WriteLine("You can't have negative length! Please input only positive numbers.");
        }
        else
        {
            if (lengthOne == lengthTwo && lengthTwo == lengthThree)
            {
                Console.WriteLine("It is an equilateral triangle!");
            }
            else if (lengthOne != lengthTwo && lengthTwo != lengthThree)
            {
                Console.WriteLine("It is a scalene triangle!");
            }
            else
            {
                Console.WriteLine("It is an isosceles triangle!");
            }
            Console.WriteLine("\nDone.");
        }
    }
}