using System;
using System.Collections.Generic;
namespace tasks
{
    static class Task1
    {
        public static List<string> FunctionFfromX(string[] s)
        {
            List<string> arr = new List<string>();
            if (s == null)
            {
                throw new ArgumentNullException();
            }
            if (s.Length < 2 || s.Length > 101)
                throw new ArgumentOutOfRangeException();
            int count = 0;
            if(!int.TryParse(s[0],out count))
                throw new FormatException();
            if(count < 2 || count >101 || count+1 !=s.Length)
                throw new ArgumentOutOfRangeException();

            double temp = 0;
            for (int i = 1; i < s.Length; i++)
            {

                if (!double.TryParse(s[i], out temp))
                    throw new FormatException();
                if(-1000 > temp || temp > 1000)
                    throw new ArgumentOutOfRangeException();
                arr.Add(FunctionFx(temp).ToString());
            }
            return arr;
        }


        public static double FunctionFx(double x)
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
            return y;
        }
    }
}
