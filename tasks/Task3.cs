using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    static class Task3
    {
        public static long ProductOfNumber(string input)
        {
            if (input == null)
                throw new ArgumentNullException();

            string[] s = input.Split(' ');
            if (s.Length != 3)
                throw new ArgumentException();

            int a = 0;
            int b = 0;
            int n = 0;

            if (!int.TryParse(s[0], out a) || !int.TryParse(s[1], out b) || !int.TryParse(s[2], out n))
                throw new FormatException();

            if (a <= 1 || a > 9 ||
                b <= 1 || b > 9 ||
                n <= 10 || a > 99)
                throw new ArgumentOutOfRangeException();


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
                        }
                        else if (j == 0)
                        {
                            max = (long)Math.Pow(a, i) > max ? (long)Math.Pow(a, i) : max;
                        }
                        else
                        {
                            max = (long)Math.Pow(a, i) * (long)Math.Pow(b, j) > max ? (long)(Math.Pow(a, i) * (long)Math.Pow(b, j)) : max;
                        }
                    }
                    else if (a * i + b * j > n)
                        break;
                }
            }

            return max;
        }
    }
}
