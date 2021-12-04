using System;
using System.Collections.Generic;

using OpenClosePrinciple.Interfaces;
using OpenClosePrinciple.Enums;

namespace OpenClosePrinciple.Specifications
{
  public class SizeSpecification : ISpecification<ProductModel>
  {
    private Size size;

    public SizeSpecification(Size size)
    {
      this.size = size;
    }

    public bool IsSatisfied(ProductModel p)
    {
      return p.Size == size;
    }
  }
}