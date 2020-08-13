using System;
using System.Collections.Generic;


class NoOggyChecker
{
  static void RemoveOggy(List<string> names)
  {
    for(int i=0;i<names.Count;i++)
     {
      Console.WriteLine($"{names[i]}");
     }
      Console.WriteLine($"Remove name starts with oggy!");
     for(int i=0;i<names.Count;i++)
     {
      if(names[i].StartsWith("oggy"))
       {
        Console.WriteLine($"Need to remove {names[i]}!");
        names.Remove(names[i]);
        i=i-1;
       }
     }
      Console.WriteLine($"After removing Substring oggy, Names remains in Array:");
     for(int i=0;i<names.Count;i++)
      {
     Console.WriteLine($"{names[i]}");
      }
  }
  static bool OggyIsRemoved(List<string> names)
  {
    return names.Find(x => x.Contains("oggy")) == null;
  }
  static int Main()
  {
    var names = new List<string>
      { "nobita", "bheem", "oggy", "oggy cockroach", "ninja" };
    RemoveOggy(names);
    if(OggyIsRemoved(names)) {
      Console.WriteLine("Passed!");
      return 0;
    } else {
      Console.WriteLine("Failed!!");
      return 1;
    }
  }
}
