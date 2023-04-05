using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            string name = "John";
            float per = 45.8F;

            Console.WriteLine("My number is " + num + " my name is " + name + " my percentage is " + per);
            Console.WriteLine("My name is {0} my number is {1} and my percentage is {2}", num, name, per);
            Console.WriteLine($"My name is {name} my number is {num}");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1);

            arthmetic operators
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine(num3);
            int num1 = 10;
            int num2 = 5;
            Console.WriteLine(num1 != num2);

            Accept the value of Radius from user & calculate area of circle
            radius * 3.14;
            Console.WriteLine("Enter value of radius");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = radius * 3.14;
            Console.WriteLine("The area of circle is " + area);

            Accept 3 marks of a student calculate total &percentage

            int mark1 = Convert.ToInt32(Console.ReadLine());
            int mark2 = Convert.ToInt32(Console.ReadLine());
            int mark3 = Convert.ToInt32(Console.ReadLine());

            int totalmarks = mark1 + mark2 + mark3;
            int totalpercent = totalmarks / 3;
            Console.WriteLine("Total percent is " + totalpercent);

            int a = 10;
            int b = 9;
            int c = 8;
            //Console.WriteLine(a<b || a<c);
            bool test1 = true;
            bool test2 = !test1;
            Console.WriteLine(test2);

            //Accept the two numbers from user &swap the value using 3rd variable
            int a = 2, b = 3, c;
            Console.WriteLine("Before swapping a = " + a + " b = " + b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Before swapping a = " + a + " b = " + b);

            Accept the two numbers from user &swap the value without using 3rd variable
            int a = 2, b = 3;
            Console.WriteLine("Before swapping a = " + a + " b = " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Before swapping a = " + a + " b = " + b);

            unary operator

            int a = 10;
            int b = a--;
            Console.WriteLine(b);
            ternary operator
            int a = 6;
            int b = 9;
            int result = (a > b) ? 0 : 1;
            Console.WriteLine(result);





        }
    }
}
