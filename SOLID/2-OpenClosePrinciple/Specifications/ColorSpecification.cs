using System;
using System.Collections.Generic;

using OpenClosePrinciple.Interfaces;
using OpenClosePrinciple.Enums;

namespace OpenClosePrinciple.Specifications
{
  public class ColorSpecification : ISpecification<ProductModel>
  {
    private Color color;

    public ColorSpecification(Color color)
    {
      this.color = color;
    }

    public bool IsSatisfied(ProductModel p)
    {
      return p.Color == color;
    }
  }
}