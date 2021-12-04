using System;
using System.Collections.Generic;

using OpenClosePrinciple.Interfaces;
using OpenClosePrinciple.Enums;

namespace OpenClosePrinciple.Specifications
{
  public class ColorSizeSpecification : ISpecification<ProductModel>
  {
    private Color color;
    private Size size;
    public ColorSizeSpecification(Color color, Size size)
    {
      this.color = color;
      this.size = size;
    }

    public bool IsSatisfied(ProductModel p)
    {
      return p.Color == color && p.Size == size;
    }
  }
}