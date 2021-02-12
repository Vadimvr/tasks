using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = " ";
            Stopwatch stopwatch = new Stopwatch();
            long before = GC.GetTotalMemory(false);


            string[] s = "2 3 96".Split(' ');
            int a = 0;
            int b = 0;
            int n = 0;

            try
            {
                a = int.Parse(s[0]);
                b = int.Parse(s[1]);
                n = int.Parse(s[2]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            long max = 0;
            int ia = n / a;
            int jb = n / b;



            for (int i = 0; i <= ia; i++)
            {

                for (int j = 0; j <= jb; j++)
                {

                    if (a * i + b * j == n)
                    {
                        if (i == 0)
                        {
                            max = (long)Math.Pow(b, j) > max ? (long)Math.Pow(b, j) : max;
                            Console.WriteLine(max.ToString("N0", nfi) + "   " + "i=0 " + "j=" + j);
                        }
                        else if (j == 0)
                        {
                            max = (long)Math.Pow(a, i) > max ? (long)Math.Pow(a, i) : max;
                            Console.WriteLine(max.ToString("N0", nfi) + "   " + "i=" + i + "j=0" );


                        }
                        else
                        {
                            max = (long)Math.Pow(a, i) * (long)Math.Pow(b, j) > max ? (long)(Math.Pow(a, i) * (long)Math.Pow(b, j)) : max;
                            Console.WriteLine(max.ToString("N0", nfi) + "   " + "i="+i  +"   " + "j="+j);

                        }
                    }
                    else if (a * i + b * j > n)
                        break;
                }
            }



            stopwatch.Stop();
            long after = GC.GetTotalMemory(false);
            long consumedInMegabytes = (after - before) / 1024;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("результат: " + max.ToString("N0", nfi));
            Console.WriteLine("результат: " + long.MaxValue.ToString("N0", nfi));
            Console.WriteLine("память: " + (after - before) / 1024 + "." + (after - before) % 1024);
            Console.WriteLine("Потрачено тактов на выполнение: " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine("Потрачено тактов на выполнение: " + stopwatch.ElapsedTicks);


            Console.ReadKey();
        }
        public static int CountCombinations(int money, int[] coins)
        {
            int[] table = new int[money + 1];
            table[0] = 1;

            for (int i = 0; i < coins.Length; i++)
                for (int j = coins[i]; j <= money; j++)
                    table[j] += table[j - coins[i]];
            return table[money];
        }
    }
}
