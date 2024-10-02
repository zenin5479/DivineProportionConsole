using System;

namespace DivineProportionConsole
{
   internal class Program
   {
      public const double Percent = 10;
      public const double PercentPart = 0.81;

      static void Main()
      {
         Console.WriteLine(Percent);
         Console.WriteLine(PercentPart);

         int data = 300;
         double[] x = { 100.36, 150.67, 170.96, 250.85, 30.52, 280.24, 190.12, 87.32, 96.14, 200.89 };

         double s = AverageForeachLoop(x);
         Console.WriteLine(s);

         // Если меньше этого значения среднее
         int fhalfdata = (int)(data * PercentPart);
         Console.WriteLine(fhalfdata);

         // Тогда уменьшаем заданное значение на процент
         int datafipercent = (int)(data * (Percent / 100));
         Console.WriteLine(datafipercent);

         int result = Convert.ToInt32(data - datafipercent);
         Console.WriteLine(result);

         Console.WriteLine(HowPercentIsNumber(data, s));
         Console.WriteLine(FindPercentOfNumber(data, Percent));
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

      public static int HowPercentIsNumber(int b, double a)
      {
         if (b == 0) return 0;
         return (int)(a / (double)(b / 100M));
      }

      public static int FindPercentOfNumber(int data, double a)
      {
         return (int)(data * (a / 100));
      }
   }
}