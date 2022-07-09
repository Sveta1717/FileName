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
            Console.WriteLine("Показати шлях до директорії");
            //FileStream fs = new FileStream(@"D:\Документи", FileMode.Open, FileAccess.Read);
            string text = Console.ReadLine();            

            Console.WriteLine("Введить слово яке щукаете");
            string word = Console.ReadLine();
            int i = 0;
            foreach (Match m in Regex.Matches(text, word, RegexOptions.IgnoreCase))
                i += 1;
            Console.WriteLine(i); 
        }
    }
}
