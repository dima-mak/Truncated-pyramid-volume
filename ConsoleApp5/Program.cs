using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            //int summ = 0;
            //int number = 0;
            //int unumber = 0;
            //int[] nums = { 1, -2, 5, -23 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //   if (nums[i] > 0)
            //    {
            //        number++;                   
            //    }
            //   else
            //    {
            //        unumber++;
            //    }
            //    summ += nums[i];
            //}
            //Console.WriteLine("среднее арифметическое: " + (summ / nums.Length));
            //Console.WriteLine("positive: " + number);
            //Console.WriteLine("negative: " + unumber);

            
                double v;
                int s1 = Convert.ToInt32(Console.ReadLine());
                int s2 = Convert.ToInt32(Console.ReadLine());
                int h = Convert.ToInt32(Console.ReadLine());
                v = (0.33 * h) * (s1 + s2 + Math.Sqrt(s1 * s2));
                Console.WriteLine(v);
                
            




        }

        
    }
}
