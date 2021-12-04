using OpenClosePrinciple.Enums;

namespace OpenClosePrinciple
{
  public class ProductModel
  {
    public string Name;
    public Color Color;
    public Size Size;

    public ProductModel(string name, Color color, Size size)
    {
      this.Name = name;
      this.Color = color;
      this.Size = size;
    }
  }
}