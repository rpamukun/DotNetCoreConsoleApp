using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DotNetCoreConsoleApp
{
    class RegexClass
    {
        static void Main(string[] args)
        {
            String str = "\"  This is a test string , with lots of: ? . punctuations; in it   ?!   \". ";
            string result = Regex.Replace(str, @"\s+", " ");
            result = Regex.Replace(result, @" ?([.,]) ?(?:\1 ?)*", "$1 ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
