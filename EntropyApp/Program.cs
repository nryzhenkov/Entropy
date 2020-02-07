using System;
using EntropyLib;

namespace EntropyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringAnalyzer analyzer = new StringAnalyzer("ababcc");
            Console.WriteLine(analyzer.FromStrToCode("ab ba"));
        }
    }
}
