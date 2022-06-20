using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 17)
            {
                Console.WriteLine("You are a kid");
            }
            else if (age >= 18 && age <= 50)
            {
                Console.WriteLine("You are Young");
            }
            else
            {
                Console.WriteLine("You are Old Man");
            }
        }
    }
}
