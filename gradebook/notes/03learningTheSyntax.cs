using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     Console.WriteLine("Hello Nabeel!");
        // }
        //     // right now, we're in a method called Main and inside the {} we place the code we want to execute when this method is invoked/called. This method is invoked/called when we launch a command-line application, a console application in .NET core (by convention, what we call an entry-point of the application is a method named Main). In other words, when we type 'dotnet run', what the .NET runtime is looking for is a method named Main. It recognizes that this is the entry-point for the application and starts executing the code inside of that method.
        //     // in the () following the method Main, we can have 0 or more parameters. Every parameter consists of a type and a name. Here, the name of our parameter is args (short for arguments that are being passed to the application). The type of this method is a string array (a collection of strings; [] indicates an array)

    // STRING CONCATENATION
        // static void Main(string[] args)
        // {
        //     Console.WriteLine("Hello " + args[0] + "!");
        // }

    // STRING INTERPOLATION - instead of concatenation where we're forced to break up the string, we can use one long string with a $ and {}
        // static void Main(string[] args)
        // {
        //     Console.WriteLine($"Hello, {args[0]}!");
        // }

    // DEBUGGING - PARAMETERS - IF/ELSE STATEMENTS
        // static void Main(string[] args)
        // {
        //     if (args.Length > 0)
        //     {
        //         Console.WriteLine($"Hello, {args[0]}!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Hello, you nameless life-form!");
        //     }
        // }
    
    // ADDING NUMBERS AND CREATING ARRAYS
        // // double - a fundamental data type build into the compiler and use to define numeric variables holding numbers with decimal points. it can represent fractional as well as whole values.
        // // var - a keyword, when we have an initialization expression and we're assigning value to variable at the same time declaring it, we can take advantage of a feature in C# known as 'implicit typing' and we do it with the var keyword
        //     // var is not like in JavaScript, it cannot be reassigned to another value or type; also, it can't be undefined/declared, meaning it needs to hold a value; implicitly typed variables must be initialized
        // static void Main(string[] args)
        // {
        //             // double x = 34.1;
        //             // double y = 10.3;
        //                 // essentially, we're telling the compiler is, we know you can figure out the type of this variable, based on the context of the code; in this case, that x and y are a double; benefit is that we don't need to provide an explicit type every time we create a variable
        //             // var x = 34.1;
        //             // var y = 10.3;
        //             // var result = x + y;
        //             // Console.WriteLine(result);
        //                 // "cw" is a shortcut/snippet in VS Code to Console.WriteLine();
        //             // now obviously, there will be more than two grades and we don't know how many. the solution is to create an array. Just like the argument for the Main method, we can create an array of floating-point numbers, where parameters can be passed to include as many grades as we want

        //             // double[] numbers;
        //             // numbers[0] = 12.1;
        //                 // numbers[0] would be the first number in the array, but we get an error that there's a use of unassigned local variable 'numbers' and C# won't allow it, because we're doing something with this variable that we're never assigned to.
        //                 // all we have is a variable pointing to an array that doesn't exist
        //                 // same is true for explicitly typed variables, for example"
        //                     // double x;
        //                     // x = x + 3.1;
        //                         // x is not assigned a value so that compiler will throw an error.
        //                 // we have to initialize a variable one way or another; and in order to do that, if we don't already have one is to instantiate a new array with the 'new' keyword
        //             // double[] numbers = new double[3];
        //                 //we have to provide an explicit size, in our case it will be 3 floating numbers. once we have this full initialization expression on the right side, we can use implicit typing to simplify the code
        //     var numbers = new double[3];
        //     numbers[0] = 23.1;
        //     numbers[1] = 45.6;
        //     numbers[2] = 89.7;

        //     // TO ADD ARRAY VALUES
        //     var result = numbers[0];
        //     result = result + numbers[1];
        //     result = result + numbers[2];
        //     Console.WriteLine(result);
    
    // LOOPING THROUGH ARRAYS
        // static void Main(string[] args)
        // {
        //             // var numbers = new double[3];
        //             // numbers[0] = 23.1;
        //             // numbers[1] = 45.6;
        //             // numbers[2] = 89.7;

        //             // // TO ADD ARRAY VALUES
        //             // var result = numbers[0];
        //             // result = result + numbers[1];
        //             // result = result + numbers[2];
        //             // Console.WriteLine(result);
        //     // same idea as above, but simplified            
        //     // var numbers = new double[3] { 23.1, 45.6, 89.7 };
        //     var numbers = new[] { 23.1, 45.6, 89.7, 41.7 };
        //         // instead of saying we want an array of double that hold 3 items, since we now have an initialization expression, we can leave the number out of the [] and add as many values to our array as we want, the compiler can figure out how many values we need to hold
        //         // once we have this initialization expression, we don't need to explicitly tell the C# compiler this will be an array of double. the compiler can figure out both the type and size of array
        //     // var result = numbers[0];
        //     // result += numbers[1];
        //     // result += numbers[2];
        //         // we can rewrite code as such, but don't know exactly how many numbers we'll have in numbers array; there's also duplication here so there must be an easier way; welcome foreach loops
        //     var result = 0.0;
        //     foreach(double number in numbers) 
        //     {
        //         result += number;
        //     }
        //     Console.WriteLine(result);
    
    // USING A LIST - we've been working towards is taking steps to work towards storing grades in GradeBook, then compute the average. We've seen looping, adding, but there's one big limitation. Requirements don't tell us how many grades need be stored
        // // with arrays in C#, we need to create them with a specific size
        // // fortunately, .NET libraries provide an answer in a namespace System.Collections.Generic, which contains a number of classes we can use that are data-structures (like a stack or que). 
        //     // List is one of those data-structures which allows us to keep a list of things (like floating-point numbers)
        // // every class in .NET framework is in a namespace of some sort. Namespaces help to reduce collisions; so if I write a class called List, you write a class called List, and .NET framework writes a class called List, there's an easy way to differentiate between the three because they'll essentially have different names, as long as they're in different namespaces
        // // to find the namespace, place cursor over the error and press "ctrl ." we'll see a dropdown menu that will help to fix the error 
        // static void Main(string[] args)
        // {
        //     var numbers = new[] { 23.1, 45.6, 89.7, 41.7 };
        //     // List grades;
        //         // red line indicates an error message 'type or namespace name 'List' couldn't be found because the compiler doesn't know what it is or where to look
        //         // List lives in System.Collections.Generic; so we can either explicitly type System.Collections.Generic.List or include System.Collections.Generic all the way at the top as "using System.Collections.Generic"
        //         // still error because this type requires a 'type argument'
        //             // there are certain types and classes in .NET libraries that require you provide additional info about how we'll use that particular type
        //             // so we have to describe what types of things we'll put in there, if we want to use it
        //             // in our case we only want to use double-precision floating-point numbers; so we write the syntax as follows:
        //     // List<double> grades; 
        //         // meaning, this is a List of double
        //         // we can have a var here, as long as there's an initialization statement
        //     // List<double> grades = new List<double>() { 23.1, 45.6, 89.7, 41.7 };
        //     var grades = new List<double>() { 23.1, 45.6, 89.7, 41.7 };
        //     grades.Add(98.15); 
        //     var result = 0.0;
        //     foreach(double number in grades) 
        //     {
        //         result += number;
        //     }
        //     Console.WriteLine(result);
        // }

    // COMPUTING AND FORMATTING THE RESULT (AVERAGE)
        static void Main(string[] args)
        {
            var grades = new List<double>() { 23.75345, 45.244236, 89.76577, 41.365347 };
            grades.Add(98.1566);

            var result = 0.0;
            foreach(double number in grades) 
            {
                result += number;
            }

            // result = result / grades.Count;
            result /= grades.Count;

            Console.WriteLine($"The average grade is {result}.");
            Console.WriteLine($"The average grade is {result:N2} rounded to two digits.");
        }
    }
}
