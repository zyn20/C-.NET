using System;

namespace MyApp
{
  enum score
  {
    Low,
    Medium,
    High
  }
  class Program
  {
    static void Main(string[] args)
    {
      score Var = score.Medium;
      Console.WriteLine(Var);
    }
  }
}
