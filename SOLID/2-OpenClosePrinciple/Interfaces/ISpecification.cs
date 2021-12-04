namespace OpenClosePrinciple.Interfaces
{
  public interface ISpecification<T>
  {
    bool IsSatisfied(ProductModel p);
  }
}