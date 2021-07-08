using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreConsoleApp
{
    class GenericsClass
    {
        static void Main()
        {
            bool equal = calculator.AreEqual<String>("A", "A");
            Console.WriteLine(equal);
            Console.ReadLine();

        }

    }

    class calculator
    {

        public static bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }

    }
}
