using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTW_BTH1_Bai_3
{
    internal class Program
    {
        static void generateMatrix(int[,] a, int n, int m)
        {
            Random rd = new Random();
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    a[i, j] = rd.Next();
        }

        static void outputMatrix(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();    
            }
        }

        static int findMaxElenment(int[,] a, int n, int m)
        {
            int mx = a[0, 0];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (a[i, j] > mx)
                        mx = a[i, j];
                }
            }
            return mx;
        }

        static int findMinElenment(int[,] a, int n, int m)
        {
            int mn = a[0, 0];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (a[i, j] < mn)
                        mn = a[i, j];
                }
            }
            return mn;
        }

        static int findBiggestRow(int[,] a, int n, int m)
        {
            // Find sum of First row
            int sum = 0;
            for (int i = 0; i < m; ++i)
                sum += a[0, i];

            // Compare
            int r = 0, tmp;
            for (int i = 1; i < n; ++i)
            {
                tmp = 0;
                for (int j = 0; j < m; ++j)
                    tmp += a[i, j];
                if (tmp > sum)
                {
                    r = i;
                    sum = tmp;
                }
            }
            return r;
        }

        static bool isPrime(int n)
        {
            for (int  i = 2; i * i <= n; ++i)
            {
                if (n % i == 0)
                    return false;
            }
            return (n > 1);
        }

        static int SumOfNumberIsNotPrime(int[,] a, int n, int m)
        {
            int sum = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (isPrime(a[i, j]) == false)
                        sum += a[i, j];
                }
            }
            return sum;
        }

        static void DeleteKthRow(int[,] a, ref int n, int m)
        {
            Console.Write("Which line do you want to delete: ");
            int k = int.Parse(Console.ReadLine());
            if (k >= n)
            {
                Console.WriteLine("Out of Matrix range!");
                return;
            }
            if (k == n - 1) --n;
            for (int i = k - 1; i < n - 1; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    (a[i, j], a[i + 1, j]) = (a[i + 1, j], a[i, j]);
                }
            }
            --n;

            Console.WriteLine("Deleted row {0} successful!", k);
        }

        static void DeleteColHasBiggestSum(int[,] a, int n, ref int m)
        {
            // Find index of max element
            int col = 0, mx = a[0,0];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (a[i, j] > mx)
                    {
                        mx = a[i, j];
                        col = j;
                    }
                }
            }

            // Delete
            if (col == m - 1) --m;
            for (int i = 0; i < n; ++i)
            {
                for (int j = col; j < m - 1; ++j)
                {
                    (a[i, j], a[i, j + 1]) = (a[i, j + 1], a[i, j]);
                }
            }
            --m;

            Console.WriteLine("Deleted max col successful!");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of row: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter number of column: ");
            int m = int.Parse(Console.ReadLine());

            int[,] a = new int[n, m];
            generateMatrix(a, n, m);

            Console.WriteLine("--------------------------");
            Console.WriteLine("*** Matrix's form *** ");
            outputMatrix(a, n, m);

            Console.WriteLine("--------------------------");
            Console.WriteLine("Max element of Matrix: {0}", findMaxElenment(a, n, m));  

            Console.WriteLine("--------------------------");
            Console.WriteLine("Min elenment of Matrix: {0}", findMinElenment(a, n, m));

            Console.WriteLine("--------------------------");
            Console.WriteLine("Row that has biggesst sum: {0}", findBiggestRow(a, n, m));

            Console.WriteLine("--------------------------");
            Console.WriteLine("Sum of all elements that's not prime number: {0}", SumOfNumberIsNotPrime(a, n, m));  

            Console.WriteLine("--------------------------");
            DeleteKthRow(a, ref n, m);

            Console.WriteLine("--------------------------");
            DeleteColHasBiggestSum(a, n, ref m);

            Console.ReadKey();
        }
    }
}
