using System;

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
         double[] x = { 100.36, 150.67, 170.96, 250.85, 30.52, 280.24, 190.12, 87.32, 96.14, 200.89 };

         double s = AverageForeachLoop(x);
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

      public static double AverageForeachLoop(double[] sourceArray)
      {
         double result = 0;
         foreach (double item in sourceArray)
            result += item;
         double average = result / sourceArray.Length;
         return average;
      }

      public static int GetPercent(int b, double a)
      {
         if (b == 0) return 0;
         return (int)(a / (double)(b / 100M));
      }
   }
}