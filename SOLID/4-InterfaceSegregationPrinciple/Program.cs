using System;

namespace _4_InterfaceSegregationPrinciple
{
  public class Document { }
  public interface IPrinter
  {
    void Print(Document d);
  }
  public interface IScanner
  {
    void Scann(Document d);
  }
  public interface MultiFunctionMachine : IPrinter, IScanner { }

  public class Printer : IPrinter
  {
    private IPrinter Printer;
    public Printer(IPrinter Printer)
    {
      this.Printer = Printer;
    }
    void Print(Document d)
    {
      Printer.Print(d);
    }
  }

  public struct Photocopier : IPrinter, IScanner
  {
    private IPrinter Printer;
    private IScanner Scanner;
    public Photocopier(IPrinter Printer, IScanner Scanner)
    {
      if (Printer == null)
      {
        throw new ArgumentNullException(paramName: nameof(printer));
      }
      if (Scanner == null)
      {
        throw new ArgumentNullException(paramName: nameof(Scanner));
      }
      this.Printer = Printer;
      this.Scanner = Scanner;
    }
    void Print(Document d)
    {
      Printer.Print(d);
    }
    void Scan(Document d)
    {
      Scanner.Scann(d);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
