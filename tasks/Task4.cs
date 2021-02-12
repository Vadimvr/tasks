using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    static class Task4
    {
        public static int ReverseMice(int white, int black)
        {
            if (white < 1 || white > 1000 || black < 1 || black > 1000)
                throw new ArgumentOutOfRangeException();
            string[] x = new string[white + black + 1];
            x[white] = "Space";
            for (int i = 0; i < x.Length; i++)
            {
                if (i < white)
                    x[i] = "White";
                else if (i > white)
                    x[i] = "Black";
            }
            int len = x.Length - 1;
            string t;
            int j = 0;
            int count = 0;

           
            while (j < len)
            {

                for (int i = len - 1; i >= 0; i--)
                {
                    if (x[i] == "White")
                    {
                        if (x[i + 1] == "Space")
                        {
                            t = x[i + 1];
                            x[i + 1] = x[i];
                            x[i] = t;
                            count++;
                            break;
                        }
                        if (i + 2 <= len && x[i + 1] == "Black" && x[i + 2] == "Space")
                        {
                            t = x[i + 2];
                            x[i + 2] = x[i];
                            x[i] = t;
                            count++;
                        }
                    }
                }

                for (int i = 1; i <= len; i++)
                {
                    if (x[i] == "Black")
                    {
                        if (x[i - 1] == "Space")
                        {
                            t = x[i - 1];
                            x[i - 1] = x[i];
                            x[i] = t;
                            count++;
                            if (i != 1)
                                break;
                        }
                        if (i - 2 >= 0 && x[i - 1] == "White" && x[i - 2] == "Space")
                        {
                            t = x[i - 2];
                            x[i - 2] = x[i];
                            x[i] = t;
                            count++;
                        }
                    }
                }

                j++;
            }
            return count;

        }

    }
}
