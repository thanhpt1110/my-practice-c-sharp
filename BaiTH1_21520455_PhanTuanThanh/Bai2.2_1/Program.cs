using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bai2._2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap duong dan cua thu muc: ");
            string strFile = Console.ReadLine();
            if (Directory.Exists(strFile))
            {
                string[] Files = Directory.GetFiles(strFile);
                string[] Folders = Directory.GetDirectories(strFile);

                if (Folders.Length != 0)
                { 
                    Console.WriteLine("\nTat ca thu muc con trong thu muc nay:");
                    for (int i = 0; i < Folders.Length; ++i)
                        Console.WriteLine(Folders[i]);
                }
                else
                    Console.WriteLine("Khong co thu muc con trong thu muc nay!");

                Console.WriteLine();

                if (Files.Length != 0)
                {
                    Console.WriteLine("Tat ca file trong thu muc nay:");
                    for (int i = 0; i < Files.Length; ++i)
                        Console.WriteLine(Files[i]);
                }
                else
                    Console.WriteLine("Khong co tap tin nao trong thu muc!");
            }
            else
                Console.WriteLine("Khong tim thay thu muc!");
            Console.ReadKey();
        }
    }
}
