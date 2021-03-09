using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task2
{
    class Program
    {
        static void DeleteSymbol(ref string str, params char[] symbol)
        {
            foreach (var item in symbol)
            {
                str = str.Replace(item.ToString(), String.Empty);
            }
        }
        static string Multiply(string source, int multiplier)
        {
            StringBuilder sb = new StringBuilder(multiplier * source.Length);
            for (int i = 0; i < multiplier; i++)
            {
                sb.Append(source);
            }

            return sb.ToString();
        }
        static void CountLettersInString(String str)
        {
            char[] symbols = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'j', 'k', 'l', 'h', 'm', 'n', 's', 'p', 'r', 't', 'q', 'z' };
            int counts = 0;
            foreach (var item in symbols)
            {
                counts = str.Count(e => (e).Equals(item));
                if (counts != 0)
                {
                    Console.WriteLine($"{item}: [{counts}] {Multiply("*", counts)}");

                }
            }
        }
        static void Main(string[] args)
        {
            string str = "wdawdwad2233";
            DeleteSymbol(ref str, '2','3' );
            Console.WriteLine($"STR : {str}");
            CountLettersInString("I don’t know whether to delete this or rewrite it");
        }
    }
}
