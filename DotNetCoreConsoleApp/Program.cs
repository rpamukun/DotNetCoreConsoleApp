using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the range of number list \n");
            int range = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number list \n");
            for (int i = 0; i <= range; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                numbers.Add(n);
            }
            IEnumerable<int> number = numbers.Where(n => n % 7 == 0);
            Console.WriteLine("List of Numbers divded by 7 \n");
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Max value in List of Numbers divded by 7 is \n");
            int highestD7 = numbers.Where(n => n % 7 == 0).Max();
            Console.WriteLine(highestD7);
            Console.WriteLine("Second Max value in List of Numbers divded by 7 is \n");
            int SecondhighestD7 = numbers.Where(n => n % 7 == 0 & n<highestD7).Max();
            Console.WriteLine(SecondhighestD7);
        }
    }
}
