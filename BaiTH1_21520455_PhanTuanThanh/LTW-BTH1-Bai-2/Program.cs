using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTW_BTH1_Bai_2
{
    internal class Program
    {
        static void generateNumber(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Random rd = new Random();
                a[i] = rd.Next();
            }
        }

        static int sumOfOddNumber(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; ++i)
            {
                if (a[i] % 2 != 0)
                    sum += a[i];                
            }
            return sum;
        }

        static bool isPrime(int n)
        {
            for (int i = 2; i * i <= n; ++i)
                if (n % i == 0)
                    return false;
            return (n > 1);
        }

        static bool isSquare(int n)
        {
            int tmp = (int)Math.Sqrt(n);
            return (tmp * tmp == n);
        }

        static int countPrimeNumber(int[] a, int n)
        {
            int cnt = 0;
            for (int i = 0; i < n; ++i)
            {
                if (isPrime(a[i])) ++cnt;
            }
            return cnt; 
        }

        static int findMinimalSquareNumber(int[] a, int n)
        {
            int res = int.MaxValue;
            for (int i = 0; i < n; ++i)
            {
                if (a[i] < res && isSquare(a[i]))
                    res = a[i];
            }
            if (res == int.MaxValue)
                return -1;
            return res;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of element in array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            generateNumber(a, n);

            Console.WriteLine("Sum of odd number in array = {0}", sumOfOddNumber(a, n));

            Console.WriteLine("Number of prime number in array = {0}", countPrimeNumber(a, n));

            int ans = findMinimalSquareNumber(a, n);
            if (ans == -1)
                Console.WriteLine("There is no square number in array.");
            else 
                Console.WriteLine("The minimal square number in array = {0}", ans);
        }
    }
}
