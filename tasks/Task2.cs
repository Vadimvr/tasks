using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    static class Task2
    {
        public static double DistanceInKilometers(string[] sInput)
        {

            int precision = 3;
            if (sInput == null)
                throw new ArgumentNullException();

            int[] wheelsAndTires = GetWheelsAndTires(sInput[0]);

            if (sInput.Length != wheelsAndTires[0] + 1)
                throw new ArgumentException();

            return Math.Round((double)wheelsAndTires[1] / TireWear(sInput), precision);
        }


        static int[] GetWheelsAndTires(string wheelsAndTires)
        {
            string[] temp = wheelsAndTires.Split(' ');
            if (temp.Length != 2)
                throw new ArgumentOutOfRangeException();

            int wheels = 0;
            int tires = 0;

            if (!int.TryParse(temp[0], out wheels) || !int.TryParse(temp[1], out tires))
                throw new FormatException();

            if (wheels < 4 || wheels > 10 || wheels % 2 != 0 || tires < wheels || tires > 20)
                throw new ArgumentOutOfRangeException();

            return new int[] { wheels, tires };
        }


        static double TireWear(string[] sInput)
        {
            double wearRate = 0;
            double temp;
            for (int i = 1; i < sInput.Length; i++)
            {
                temp = 0;
                if (!double.TryParse(sInput[i], out temp))
                    throw new FormatException();
                if (temp <= 0 || temp > 3000)
                    throw new ArgumentOutOfRangeException();

                wearRate += 1 / temp;
            }
            return wearRate;
        }
    }
}
