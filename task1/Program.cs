using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = -1000; i < 1001; i++)
            {
                Console.WriteLine(fun(i));
            }
            Console.ReadKey();
        }
        public static double fun(double x)
        {
            double[] _x = new double[] { -7, -4, 0, 1.234, 3, 10 };
            double[] _y = new double[] { 1132.856, -17.344, 123.456, 97.575, 56.856, 9323.456 };
            double temp = 0;
            double y = 0;
            for (int i = 0; i < _x.Length; i++)
            {
                temp = _y[i];
                for (int j = 0; j < _x.Length; j++)
                {
                    if (i != j)
                    {
                        temp *= (x - _x[j]) / (_x[i] - _x[j]);
                    }
                }
                y += temp;
            }
            return Math.Round( y,3);
        }
    }
}
