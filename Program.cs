using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} is less than {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }

            
            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Good job!");
                    break;
                case 'D':
                    Console.WriteLine("Needs improvement");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;
            }

            
            int count = 1;
            while (count <= 5)
            {
                Console.Write($"{count} ");
                count++;
            }
            Console.WriteLine();

            
            for (int i = 5; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            
            string[] fruits = { "Apple", "Banana", "Orange", "Mango" };
            foreach (string fruit in fruits)
            {
                Console.Write($"{fruit} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

