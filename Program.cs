using System;
using System.Collections.Generic;
using System.IO;

namespace solution
{ 
    class Program
{
    static void Main(string[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "PolyIlaro";
        Console.WriteLine("enter the second integer");
        int new_int = int.Parse(Console.ReadLine());
        Console.WriteLine("enter double variable");
        double new_double = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter string variable");
        string new_string = (Console.ReadLine());


        Console.WriteLine(i + new_int);
        Console.WriteLine(d + new_double);
        Console.WriteLine(s + new_string);


    }
}
}
