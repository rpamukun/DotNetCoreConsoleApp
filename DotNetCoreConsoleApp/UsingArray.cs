using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetCoreConsoleApp
{
    class UsingArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range of number list \n");
            int i = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[i];
            Console.WriteLine("Enter the number lst \n");
            for (int n = 0; n < i; n++)
            {
                numbers[n] = Convert.ToInt32(Console.ReadLine());
            }
            IEnumerable<int> number = from num in numbers where num % 7 == 0 select num;
            Console.WriteLine("List of Numbers divded by 7 are \n");
            foreach (int j in number)
            {
                Console.WriteLine(j);
            }
        }
    }
}
