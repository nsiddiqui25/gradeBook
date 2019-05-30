using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 23.75345, 45.244236, 89.76577, 41.365347 };
            grades.Add(98.1566);

            var result = 0.0;
            foreach(double number in grades) 
            {
                result += number;
            }
            result /= grades.Count;

            Console.WriteLine($"The average grade is {result}.");
            Console.WriteLine($"The average grade is {result:N2} rounded to two digits.");
        }
    }
}
