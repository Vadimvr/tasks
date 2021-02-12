using System;
using System.Diagnostics;


namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            long before = GC.GetTotalMemory(false);
            int white = 1000;
            int black = 1000;
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
           
            stopwatch.Start();
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
                        if (i+2 <= len && x[i + 1] == "Black" && x[i + 2] == "Space")
                        {
                            t = x[i + 2];
                            x[i + 2] = x[i];
                            x[i] = t;
                            count++;
                        }
                    }
                }
               
                for (int i = 1; i <=len; i++)
                {
                    if (x[i] == "Black")
                    {
                        if (x[i - 1] == "Space")
                        {
                            t = x[i - 1];
                            x[i - 1] = x[i];
                            x[i] = t;
                            count++;
                            if (i !=1)
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
            stopwatch.Stop();
            long after = GC.GetTotalMemory(false);
            long consumedInMegabytes = (after - before) /1024;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("память: " + (after - before) / 1024 +"."+(after - before) % 1024);
            Console.WriteLine("Потрачено тактов на выполнение: " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine("Потрачено тактов на выполнение: " + stopwatch.ElapsedTicks);

            Console.WriteLine(count);
            Console.ReadKey();

        }

    }
}
