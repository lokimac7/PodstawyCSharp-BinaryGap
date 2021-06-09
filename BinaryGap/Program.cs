using System;

namespace BinaryGap
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            Console.WriteLine(Convert.ToString(1054, 2) + " => " + calc.BinaryGap(1054));
            Console.WriteLine(Convert.ToString(100, 2) + " => " + calc.BinaryGap(100));
            Console.WriteLine(Convert.ToString(64, 2) + " => " + calc.BinaryGap(64));
            Console.WriteLine(Convert.ToString(64000, 2) + " => " + calc.BinaryGap(64000));
            Console.WriteLine(Convert.ToString(256, 2) + " => " + calc.BinaryGap(256));
            Console.WriteLine(Convert.ToString(10000000, 2) + " => " + calc.BinaryGap(10000000));
            Console.WriteLine(Convert.ToString(1, 2) + " => " + calc.BinaryGap(1));
            Console.WriteLine(Convert.ToString(0, 2) + " => " + calc.BinaryGap(0));
            Console.WriteLine(Convert.ToString(-20, 2) + " => " + calc.BinaryGap(-20));
            Console.WriteLine(Convert.ToString(-64, 2) + " => " + calc.BinaryGap(-64));
            Console.WriteLine(Convert.ToString(-1054, 2) + " => " + calc.BinaryGap(-1054));
            Console.WriteLine(Convert.ToString(-99999, 2) + " => " + calc.BinaryGap(-99999));
        }

        public class Calculation
        {
            public int BinaryGap(int number)
            {
                int n = 0;
                int temporaryN = 0;
                string str = Convert.ToString(number, 2);
                int firstOneIndex = str.IndexOf("1");
                int lastOneIndex = str.LastIndexOf("1");

                if (firstOneIndex == -1 || firstOneIndex == lastOneIndex)
                    return n = 0;
                else
                {
                    for (int i = firstOneIndex + 1; i <= (lastOneIndex - firstOneIndex); i++)
                    {
                        if (str[i] == '0')
                            temporaryN++;
                        else
                        {
                            n = n < temporaryN ? temporaryN : n;
                            temporaryN = 0;
                        }
                    }
                    return n;
                }
            }
        }
    }
}
