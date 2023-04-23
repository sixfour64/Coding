/*

dotnet --info && dotnet --list-runtimes && dotnet --list-sdks && dotnet --version && dotnet sdk check

dotnet run --project /home/runner/Coding/Main.csproj
   if in GitHub CodeSpaces:
     dotnet run --project Main.csproj

*/

using System;
using System.Collections;
using Humanizer;

namespace Coding;

class Program {
  public static void Main (string[] args) {
Console.WriteLine ($"{Environment.NewLine}Hello World  is dotnet run --project /home/runner/Coding/Main.csproj\n");

var dayOfWeek = DateTime.Now.DayOfWeek;
Console.WriteLine(dayOfWeek);

string message = dayOfWeek switch 
{
    DayOfWeek.Monday     => "I've got a case of the Mondays",
    DayOfWeek.Friday     => "It's FRI-YAY!!!",
    DayOfWeek.Sunday     => "It's Sundee!!!",
    _                    => "Default statement"
};
Console.WriteLine(message);


// Parameterless constructor for class Person:
var pers = new Person();
Console.WriteLine($"{Environment.NewLine}Person as var is class: {pers.Pname} \tAge: {pers.age}");
RuntimeTypeHandle varPers = Type.GetTypeHandle(pers); 
Console.WriteLine("varPers.Value:  {0}", varPers.Value);
Console.WriteLine("varPers.GetType():  {0}", varPers.GetType());
Console.WriteLine($".{Environment.NewLine}");
// Output:  Name: unknown, Age: 0

Person persObj = new Person { Pname = "Petey" };
Console.WriteLine ($"Person class obj instance with name= {persObj}");   // Petey
Console.WriteLine ("persObj.GetType():  {0}", persObj.GetType());
Console.WriteLine ("typeof(Person):  {0}", typeof(Person));

RuntimeTypeHandle myRTHFromObject = Type.GetTypeHandle(persObj);
Console.WriteLine("myRTHFromObject.Value:  {0}", myRTHFromObject.Value);
Console.WriteLine("myRTHFromObject.GetType():  {0}", myRTHFromObject.GetType());

RuntimeTypeHandle myRTHFromType = typeof(Person).TypeHandle;
Console.Write("Get the type back from the handle:  ");
Console.WriteLine("Type.GetTypeFromHandle(myRTHFromObject):  {0}",
Type.GetTypeFromHandle(myRTHFromObject));

Console.WriteLine($".{Environment.NewLine}");
  

// for Exceptions and writing your owqn too, see Fritz ep08  @  https://www.youtube.com/watch?v=Vj3GJTUaIaQ&list=PLdo4fOcmZ0oXv32dOd36UydQYLejKR61R&index=9
decimal Divide(decimal arg1, decimal? arg2) {

    try {
        return arg1 / arg2.Value;
      } catch (DivideByZeroException) {
        Console.WriteLine("Division by zero is not allowed");
        return 0;
      } catch {
        Console.WriteLine("You broke something else");
        throw;
      }

Console.WriteLine(Divide(4, 0)+"  DivideByZeroException throws here\n.");
  }


var fs = default(FileStream);

          try{
    // Opens a text tile.
    fs = new FileStream(@"./readme.md", FileMode.Open);
    var sr = new StreamReader(fs);

    // A value is read from the file and output to the console.
    string? line = sr.ReadLine();
    Console.WriteLine(line);
  }

      catch (FileNotFoundException e) {
    Console.WriteLine($"[Data File Missing] {e}{Environment.NewLine}{e.StackTrace}{Environment.NewLine}");
    throw new FileNotFoundException(@$"[./read.md not in replit root dir / c:\temp directory]{Environment.NewLine}.", e);
  }

      finally {
    if (fs != null)
        fs.Close();
  }


    
    
} // end Main method
}  // end Class


public class Person
{
    public int age;
    public string Pname = "unknown";
  
// Method that overrides the base class (System.Object) implementation.
public override string ToString()
    {
        return Pname;
    }
  }

/*

dotnet add Main.csproj package Microsoft.EntityFrameworkCore

  https://github.com/Humanizr/Humanizer 
added to it as a package, 
dotnet add package --help
dotnet add [<PROJECT>] package <PACKAGE_NAME> [options]
dotnet add [<PROJECT>] package Humanizer --version 2.14.1
dotnet add Main.csproj package Humanizer --version 2.14.1
see also: 
  https://www.nuget.org/packages/Humanizer#readme-body-tab

*/
