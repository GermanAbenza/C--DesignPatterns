using System.IO;

namespace SingleResponsibilityPrinciple
{
  public class Persistance
  {
    public void SaveToFile(Journal journal, string fileName, bool overWrite = false)
    {
      if (overWrite || !File.Exists(fileName))
      {
        File.WriteAllText(fileName, journal.ToString());
      }
    }
  }
}