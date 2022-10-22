using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTW_BTH1_Bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month, year;
            Console.Write("Enter month: "); month = int.Parse(Console.ReadLine());
            Console.Write("Enter year: "); year = int.Parse(Console.ReadLine());

            // Process
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:    
                case 12:
                    {
                        Console.WriteLine("This month has 31 days!");
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        Console.WriteLine("This month has 30 days!");
                        break;
                    }
                case 2:
                    {
                        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                            Console.WriteLine("This month has 29 days");
                        else
                            Console.WriteLine("This month has 28 days");
                        break;
                    }
            }
        }
    }
}
