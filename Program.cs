using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("**********Please Enter Your Name*********");
            name = Console.ReadLine();
            Console.WriteLine("***Wecome To C# and DotNet Course **"+name+"**");
            
            //Addition of two numbers
            int num1 = 10;
            int num2 = 20;
            int c = num1 + num2;
            Console.WriteLine("Addition is = " + c);
            Console.WriteLine("The addition of {0} and {1} is = {2}", num1, num2, c);
            // user input 
            int x, y, z;
            Console.Write("Enter the first number = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number = ");
            y = Convert.ToInt32(Console.ReadLine());

            z = x + y;
            Console.WriteLine("addition of numbers = "+z);

        }
    }
}

