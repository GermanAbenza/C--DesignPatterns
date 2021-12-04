using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SingleResponsibilityPrinciple
{
  class Program
  {
    static void Main(string[] args)
    {
      Journal j = new Journal();
      j.AddEntry("I created this");
      j.AddEntry("And it works");
      Console.WriteLine(j);

      Persistance p = new Persistance();
      string fileName = @"C:\Users\gaben\Desktop\journal.txt";
      p.SaveToFile(j, fileName);
      Process.Start(fileName);
    }
  }
}
