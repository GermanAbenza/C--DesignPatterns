using System;

using OpenClosePrinciple.Enums;
using OpenClosePrinciple.Specifications;

namespace OpenClosePrinciple
{
  class Program
  {
    static void Main(string[] args)
    {
      var apple = new ProductModel("Apple", Color.red, Size.small);
      var tree = new ProductModel("Tree", Color.red, Size.medium);
      var house = new ProductModel("House", Color.yellow, Size.large);

      ProductModel[] products = { apple, tree, house };

      var f = new OpenFilter();

      foreach (var p in f.Filter(products, new ColorSpecification(Color.red)))
      {
        Console.WriteLine($" - {p.Name} is green");
      }
      foreach (var p in f.Filter(products, new SizeSpecification(Size.small)))
      {
        Console.WriteLine($" - {p.Name} is small");
      }
      foreach (var p in f.Filter(products, new ColorSizeSpecification(Color.red, Size.small)))
      {
        Console.WriteLine($" - {p.Name} is red and small");
      }
    }
  }
}
