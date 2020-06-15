using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Empty();
            Program.Task3();
        }

        public static void Empty()
        {
            string[] emptyString;
        }
        public static void Task3()
        {
            int[] num = new int[13];
            Random rnd = new Random();
            int max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                int random = rnd.Next(0, 100);
                num[i] = random;

                if (num[i] > max)
                {
                    max = num[i];
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", num));
            Console.WriteLine(max);
        }
    }
}



