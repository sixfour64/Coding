using System.Collections;

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

      }
  }


/*

dotnet run --project /home/runner/Coding/Scratch.csproj


*/