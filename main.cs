using System;

class Program {
    static void Main(string[] args) {
      Console.WriteLine("enter value of x");
      string s = Console.ReadLine();
      double x1 = double.Parse(s);
      s = Console.ReadLine();
      double x2 = double.Parse(s);
      s = Console.ReadLine();
      double dx = double.Parse(s);
      while (x1<=x2)
      {
        
        if ((x >= -7) & (x <= -4))
                Console.WriteLine("y = " + (2 * x - 11));
            else if ((x > -4) & (x <= -1))
                Console.WriteLine("y = " + (-x - 1));
            else if ((x > -1) & (x <= 5))
                Console.WriteLine("y = " + (-Math.Sqrt(9 - (Math.Pow(x - 2, 2)))));
            else if ((x > 5) & (x <= 7))
                Console.WriteLine("y = " + (-x + 5));
            else if ((x > 7) & (x <= 9))
                Console.WriteLine("y = " + (-2));
            else
                Console.WriteLine("error");
        x1+=dx
      }
      Console.ReadLine();
        
    }
}