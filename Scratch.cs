/*

dotnet --info && dotnet --list-runtimes && dotnet --list-sdks && dotnet --version && dotnet sdk check && dotnet run --project /home/runner/Coding/Scratch.csproj

dotnet run --project /home/runner/Coding/Scratch.csproj

*/

using System.Collections;
using Humanizer;

namespace Coding;

  class Scratch
  {
    static void Main(string[] args)
    {
Console.WriteLine("Hello World!  Scratch me!!"); 
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
var person = new Person();
Console.WriteLine($"Name: {person.name}, Age: {person.age}");
// Output:  Name: unknown, Age: 0


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
}

Console.WriteLine(Divide(4, 0)+"  DivideByZeroException throws here\n.");



var fs = default(FileStream);
try
{
    // Opens a text tile.
    fs = new FileStream(@"./readm.md", FileMode.Open);
    var sr = new StreamReader(fs);

    // A value is read from the file and output to the console.
    string? line = sr.ReadLine();
    Console.WriteLine(line);
}
catch (FileNotFoundException e)
{
    Console.WriteLine($"[Data File Missing] {e}{Environment.NewLine}{e.StackTrace}{Environment.NewLine}");
    throw new FileNotFoundException(@$"[./read.md not in replit root dir / c:\temp directory]{Environment.NewLine}.", e);
}
finally
{
    if (fs != null)
        fs.Close();
}

      
      
 }    // end method Main 
    
}  // end class
    
public class Person
{
    public int age;
    public string name = "unknown";
}


/*

*/