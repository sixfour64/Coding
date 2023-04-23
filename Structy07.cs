/* Structy07.cs

dotnet run --project /home/runner/Coding/Struct07.csproj
   if in GitHub CodeSpaces:
     dotnet run --project Structy07.csproj

*/

using System;
namespace Coding;

  class Structy
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World! --Structy07.cs-- ");

var webopt = new WebOptions();
Console.WriteLine($"{webopt.Protocol} {Environment.NewLine}.");
webopt.Protocol ="ftp";
Console.WriteLine($"{webopt.Protocol} {Environment.NewLine}.");
       
Console.WriteLine(" --Structy07.cs-- ");       
       
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
Adding the ref modifier to a struct’s declaration ensures that it can only ever reside on the stack.
Default accessibility for members of a class or struct is 'private'
*/
