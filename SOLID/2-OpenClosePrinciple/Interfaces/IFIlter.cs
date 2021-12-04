using System;
using System.Collections.Generic;

namespace OpenClosePrinciple.Interfaces
{
  public interface IFIlter<T>
  {
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
  }
}