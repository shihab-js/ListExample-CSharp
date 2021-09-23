using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a list of string
            var names = new List<string>();

            //add some elements
            names.Add("Shihab");
            names.Add("Rayhan");
            names.Add("Mishu");

            //Iterate list elements using foreach loop
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
