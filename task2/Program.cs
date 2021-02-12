using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int precision = 3;
            int wheels = 4;
            int tires = 4;
            double wearRate = 0;
            double[] x = new double[]
                        {
                3000,3000,300,300
                        };

            for (int i = 0; i < wheels; i++)
            {
                wearRate += 1 / x[i];
            }
            Console.WriteLine(Math.Round( tires / wearRate, precision));


            tires = 6;
            x = new double[]
           {
                2000,2000,1000,1000
           };
            wearRate = 0;
            for (int i = 0; i < wheels; i++)
            {
                wearRate += 1 / x[i];
            }
            Console.WriteLine(Math.Round(tires / wearRate, precision));

            Console.ReadKey();
        }
    }
}
