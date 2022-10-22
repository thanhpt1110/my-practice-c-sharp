using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardlizeString
{
    internal class Program
    {
        static public string stdString(string s)
        {
            string res = s;
            if (!String.IsNullOrEmpty(s))
            { 
                string[] words = res.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    string tmp = words[i].ToLower();
                    if (tmp.Length > 0)
                    {
                        words[i] = tmp[0].ToString().ToUpper() + tmp.Substring(1);
                    }
                }
                res = String.Join(" ", words);
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string name: ");
            string s = Console.ReadLine();

            Console.WriteLine("String name after standardlization: " + stdString(s));

            Console.ReadKey();
        }
    }
}
