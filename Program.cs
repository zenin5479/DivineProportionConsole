using System;

namespace DivineProportionConsole
{
   internal class Program
   {
      private const double Percent = 10;

      static void Main()
      {
         Console.WriteLine(Percent);

         int data = 300;
         double[] x = { 100.36, 150.67, 170.96, 250.85, 30.52, 280.24, 190.12, 87.32, 96.14, 200.89 };

         double s = AverageForeachLoop(x);
         Console.WriteLine(s);

         // Если меньше этого значения среднее
         int halfdata = (int)(data * (1 - (Percent / 100)));
         Console.WriteLine(halfdata);

         // Тогда уменьшаем заданное значение на процент
         int datapercent = (int)(data * (Percent / 100));
         Console.WriteLine(datapercent);

         int result = Convert.ToInt32(data - datapercent);
         Console.WriteLine(result);

         Console.WriteLine(HowPercentIsNumber(data, s));
         Console.WriteLine(FindPercentOfNumber(data, Percent));
         Console.ReadKey();
      }

      // Cреднее значение для последовательности числовых значений через цикл foreach
      private static double AverageForeachLoop(double[] dataArray)
      {
         double result = 0;
         foreach (double item in dataArray)
            result += item;
         double average = result / dataArray.Length;
         return average;
      }

      // Сколько процентов составляет одно число от другого числа
      private static int HowPercentIsNumber(int b, double a)
      {
         if (b == 0) return 0;
         return (int)(a / (double)(b / 100M));
      }

      // Найти процент от числа
      private static int FindPercentOfNumber(int data, double a)
      {
         return (int)(data * (a / 100));
      }
   }
}