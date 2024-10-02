﻿using System;
using System.Linq;

namespace DivineProportionConsole
{
   internal class Program
   {
      // Божественная пропорция
      public const double Fi = 1.618033988749895;
      public const double Fihalf = 0.809016994374947;

      static void Main()
      {
         Console.WriteLine(Fi);
         Console.WriteLine(Fihalf);

         int data = 300;
         int[] x = { 100, 150, 170, 250, 30, 280, 190, 87, 96, 200 };

         int sr = ForeachLoop(x);
         Console.WriteLine(sr);

         int s = (int)x.Average();
         Console.WriteLine(s);

         // Если меньше этого значения среднее
         int fihalfdata = (int)(data * Fihalf);
         Console.WriteLine(fihalfdata);

         // Тогда уменьшаем заданное значение на процент
         int datafipercent = (int)(data * (Fi / 10));
         Console.WriteLine(datafipercent);

         int result = Convert.ToInt32(data - datafipercent);
         Console.WriteLine(result);

         Console.WriteLine(GetPercent(data, s));

         Console.ReadKey();
      }

      public static int ForeachLoop(int[] sourceArray)
      {
         int result = 0;

         foreach (int item in sourceArray)
            result += item;
         int average = result/sourceArray.Length;

         return average;
      }

      public static int GetPercent(int b, int a)
      {
         if (b == 0) return 0;
         return (int)(a / (b / 100M));
      }
   }
}