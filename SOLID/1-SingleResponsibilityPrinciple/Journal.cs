using System;
using System.Collections.Generic;
using System.IO;

namespace SingleResponsibilityPrinciple
{
  public class Journal
  {
    private readonly List<string> entries = new List<string>();

    private static int count = 0;

    public int AddEntry(string text)
    {
      entries.Add($"{++count}: {text}");
      return count;
    }

    public void RemoveEntrie(int index)
    {
      entries.RemoveAt(index);
    }

    public override string ToString()
    {
      return string.Join(Environment.NewLine, entries);
    }

    // ######################## breaks single responsibility principle ########################
    // public void Save(string filename, bool overwrite = false) {
    //   File.WriteAllText(filename, ToString());
    // }

    // public void load(string filename) {

    // }

    // public void Load(Uri uri) {

    // }
  }
}