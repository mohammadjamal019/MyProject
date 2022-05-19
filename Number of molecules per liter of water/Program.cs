using System;

namespace P 
{
  class Program
  {
    static void Main(string[] args)
    {
      double m = 3.0e-23, l = 950, count;
      double w;
      Console.Write("enter a weight (Liters): ");
      w = Convert.ToDouble(Console.ReadLine());

      count = (w * l) / m;

      Console.WriteLine($"  the count is: {count} ");
      Console.ReadKey();

    }
  }
}