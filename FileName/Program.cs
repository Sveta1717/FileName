using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Показати шдях до директорії");



            string text = File.ReadAllText(Console.ReadLine(), Encoding.GetEncoding(1251));

            Console.WriteLine("Введить слово яке щукаете");
            string pattern = Console.ReadLine();
            int i = 0;
            foreach (Match m in Regex.Matches(text, pattern, RegexOptions.IgnoreCase))
                i += 1;
            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
