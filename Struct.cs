using System;
namespace Coding;

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

var webopt = new WebOptions();
Console.WriteLine($"{webopt.Protocol} {Environment.NewLine}.");

 }
}
  
  
  struct WebOptions
{
  string protocol;
  public string Protocol { get => protocol ?? "https";
                           set => protocol = value;    }
}




/*
Structs:
You can define a custom value type via struct:  public struct Point { public int X; public int Y; }
Structs are Values, not references.  Structs are not inheritable.
Structs cannot be subclassed.
Each instance from a struct does not require instantiation of an object on the heap.
A struct instance cannot be null. The default value for a struct is an empty instance, with all fields empty (set to their default values).
Every field in a struct must be explicitly assigned in the constructor (or field initializer).


*/
