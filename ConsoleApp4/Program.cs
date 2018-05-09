using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  class Program
  {
    static void Main(string[] args)
    {
      int from, to;

      Console.WriteLine("Counting digits");
      Console.WriteLine();

      Console.Write("From number: ");
      from = int.Parse(Console.ReadLine());

      Console.Write("To   number: ");
      to = int.Parse(Console.ReadLine());

      Console.WriteLine();

      string s = "";
      for (int i = from; i <= to; i++)
      {
        s += i.ToString() + " ";
      }

      Console.WriteLine(s);
      Console.WriteLine();
      Console.WriteLine(CountChar(s, '0'));
      Console.WriteLine(CountChar(s, '1'));
      Console.WriteLine(CountChar(s, '2'));
      Console.WriteLine(CountChar(s, '3'));
      Console.WriteLine(CountChar(s, '4'));
      Console.WriteLine(CountChar(s, '5'));
      Console.WriteLine(CountChar(s, '6'));
      Console.WriteLine(CountChar(s, '7'));
      Console.WriteLine(CountChar(s, '8'));
      Console.WriteLine(CountChar(s, '9'));
      Console.WriteLine();
      Console.WriteLine($"TOTAL: {s.Count(ch => ch != ' ')}");

      Console.WriteLine();
      Console.WriteLine("Press any key to exit");
      Console.ReadKey(true);
    }

    private static string CountChar(string s, char v)
    {
      return $"{v} = {s.Count(ch => ch == v)}";
    }
  }
}
