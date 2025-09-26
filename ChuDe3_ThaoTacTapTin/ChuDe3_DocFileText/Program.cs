using System;
using System.IO;
using System.Text;

namespace ChuDe3_DocFileText
{
    class Program
    {
        private static void WriteReadText(string filename, string[] text)
        {
            File.WriteAllLines(filename, text);
            foreach (string s in File.ReadAllLines(filename))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string filename = "test.txt";
            WriteReadText(filename, new string[]{ "Dòng 1", "Dòng 2", "Dòng 3"});
            Console.ReadKey();
        }        
    }
}
