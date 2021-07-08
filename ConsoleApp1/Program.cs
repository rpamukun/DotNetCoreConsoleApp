using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex.Replace("This is a test string, with lots of:  punctuations; in it?!.", @"[^\w\s]", "");
        }
    }
}
