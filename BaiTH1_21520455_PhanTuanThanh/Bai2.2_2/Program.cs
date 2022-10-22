using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix
    {
        int row, col;
        int[,] a;
        public void InputMatrix()
        {
            Console.Write("Enter number of row: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Enter number of column: ");
            col = int.Parse(Console.ReadLine());

            a = new int[row, col];
            Console.WriteLine("Enter element in Matrix: ");
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    Console.Write("a[{0}, {1}]: ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void OutputMatrix()
        {
            Console.WriteLine("Form of Matrix: ");
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    Console.Write(this.a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void findElement()
        {
            bool flag = false;
            Console.Write("Enter number you want to find: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < row; ++i)
                for (int j = 0; j < col; ++j)
                    if (a[i, j] == x)
                    {
                        flag = true;
                        Console.WriteLine("This number is at row: {0}, col: {1}", i, j);
                    }
            if (flag == false)
                Console.WriteLine("This number does not exist!");
        }

        public bool isPrime(int n)
        {
            for (int i = 2; i * i <= n; ++i)
            {
                if (n % i == 0)
                    return false;
            }
            return (n > 1);
        }

        public void OutputPrimeNumber()
        {
            bool flag = false;
            Console.Write("All prime number in Matrix: ");
            for (int i = 0; i < row; ++i)
                for (int j = 0; j < col; ++j)
                    if (isPrime(a[i, j]))
                    {
                        flag = true;
                        Console.Write(this.a[i, j] + " ");
                    }
            if (flag == false)
                Console.WriteLine("Invalid!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix();
            m.InputMatrix();
            Console.WriteLine("----------------------");

            m.OutputMatrix();
            Console.WriteLine("----------------------");

            m.findElement();
            Console.WriteLine("----------------------");

            m.OutputPrimeNumber();

            Console.ReadKey();
        }
    }
}
