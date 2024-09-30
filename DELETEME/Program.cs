using System;
using System.Globalization;

namespace DELETEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            char b = 'X';
            var l = new List<string>();
            s = "ABCDEF, GHKLM, Hmhmhm, 123456789, 123456, 123456789";
            string[] words = s.Split(", ");
            foreach (string word in words)
            {
                if (word.Length % 2 == 0) 
                {
                    l.Add(word);
                }
                else 
                {     
                    l.Add(word.Remove(word.Length / 2, 1));
                }
            }
                Console.WriteLine(string.Join(", ", l));
        }
    }
}
