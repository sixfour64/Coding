/*

dotnet --info && dotnet --list-runtimes && dotnet --list-sdks && dotnet --version && dotnet run --project /home/runner/Coding/Scratch.csproj

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

var person = new Person();
Console.WriteLine($"Name: {person.name}, Age: {person.age}");
// Output:  Name: unknown, Age: 0
      
 }    // end method Main 
}  // end class
    
public class Person
{
    public int age;
    public string name = "unknown";
}

/*




*/