using System;
using System.Collections.Generic;

using OpenClosePrinciple.Interfaces;

namespace OpenClosePrinciple
{
  public class OpenFilter : IFIlter<ProductModel>
  {
    public IEnumerable<ProductModel> Filter(IEnumerable<ProductModel> items,
      ISpecification<ProductModel> spec)
    {
      foreach (ProductModel i in items)
      {
        if (spec.IsSatisfied(i)) yield return i;
      }
    }
  }
}