using System;

namespace DivineProportionConsole
{
   internal class Program
   {
      public const double F = 10;
      public const double Fhalf = 0.81;

      static void Main()
      {
         Console.WriteLine(F);
         Console.WriteLine(Fhalf);

         int data = 300;
         double[] x = { 100.36, 150.67, 170.96, 250.85, 30.52, 280.24, 190.12, 87.32, 96.14, 200.89 };

         double s = AverageForeachLoop(x);
         Console.WriteLine(s);

         // Если меньше этого значения среднее
         int fhalfdata = (int)(data * Fhalf);
         Console.WriteLine(fhalfdata);

         // Тогда уменьшаем заданное значение на процент
         int datafipercent = (int)(data * (F / 100));
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