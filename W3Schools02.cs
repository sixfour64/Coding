/* W3Schools02.cs

to run in replit's shell:  
rm -r "/home/runner/Coding/obj/" && rm -r "/home/runner/Coding/bin/"

W3Schools02-specific alt launch string for the .replit:
dotnet --info && dotnet --list-runtimes && dotnet --list-sdks && dotnet --version && dotnet sdk check && dotnet run --project /home/runner/Coding/W3Schools02.csproj

dotnet run --project /home/runner/Coding/W3Schools02.csproj

*/

namespace Coding;
  
class NLog
{
    // Private Constructor:
    private NLog() { }
    public static double e = Math.E; 
    //2.71828...
}


class W3Schools02
  {  // start Class
  
  // public static void Main(string[] args)
  public static void Main(string[] arrayname)
    {
          Console.WriteLine ("\n.\nHello World 2 - W3Schools02.cs"); 

DateTime dat1 = DateTime.Now;
string dat2 = DateTime.Now.ToString ("dd-MM-yyyy  hh:mm:ss");
    Console.WriteLine($".{Environment.NewLine}Current Time Zone: {TimeZoneInfo.Local.DisplayName}");
Console.WriteLine($"DateTime.Now {{dat1}} is: {dat1}.  \nstring {{dat2}} = DateTime.Now.ToString (\"dd-MM-yyyy  hh:mm:ss\") is: {dat2}");

DateTime dat3 = DateTime.Now;
string dat4 = dat3.ToString ("dd-MM-yyyy  hh:mm:ss");
Console.WriteLine($"System Time Zone's DateTime.Now =  {dat4} {Environment.NewLine} TimeZoneInfo.Local.DisplayName: {TimeZoneInfo.Local.DisplayName}{Environment.NewLine}TimeZoneInfo.Local.StandardName: {TimeZoneInfo.Local.StandardName} {Environment.NewLine}.");
      
Console.WriteLine("e is: {0}\n.", NLog.e);
    
int a = 5;
int b = 6;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second\n.");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second\n.");
}

int counter = 0;
while (counter < 4)
{
  Console.WriteLine($"The counter is {counter}");
  counter = counter+1;
}

for (short counter2 = -32764; counter2 < 0; counter2--)
{
  System.Console.WriteLine($"The counter is {counter2}");
}


      
var namesListOf = new List<string> {"dude","Ana", "Felipe"};
// You specify the type of the elements in the List<T> between the angle brackets.
// List<T> type can grow or shrink via add remove
// The List<T> enables you to reference individual items by index as well. You access items using the [ and ] tokens.

Console.WriteLine("\n.\nCapacity: {0}", namesListOf.Capacity);
Console.WriteLine("Count: {0}", namesListOf.Count);

int nameItemEnum = -1;
foreach (string nameItem in namesListOf)
{
nameItemEnum++;
Console.WriteLine($"foreach {nameItem} is index# {nameItemEnum}");
Console.WriteLine($"foreach {nameItem.ToUpper()}");
}

// int or var myindex = namesListOf.IndexOf("Ana");
// System.Int32 is longhand version of 'int'
System.Int32 myindex = namesListOf.IndexOf(namesListOf[0]);
Console.WriteLine($"The name {namesListOf[myindex]} is at index# {myindex}");
var notFound = namesListOf.IndexOf("Not Found");
Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

Console.WriteLine(".");
for (int countr = 0; countr < namesListOf.Count; countr++)
{
  Console.WriteLine($"for {namesListOf[countr]} is List's index# {countr}");
  Console.WriteLine($"for {namesListOf[countr].ToUpper()}!");
}

namesListOf.Clear();
int Cap=namesListOf.Capacity;
int Cnt=namesListOf.Count;
Console.WriteLine($".\ncapacity= {Cap}");
Console.WriteLine($"count= {Cnt}");
      
      
/* 
When calling methods with multiple 'out' parameters, sometimes you’re not interested in receiving values back from the method for all the returned parameters. In such cases, you can “discard” the ones in which you’re uninterested by using an underscore _  
e.g. out string a, out _);     this _ is called a 'discard'
*/

//  how out works:  "123" is string then we parse it into an int
bool successful = int.TryParse ("123", out int result);
Console.WriteLine ($"\n.How out works: {result}, {result+result}");

      
Console.WriteLine($"{Environment.NewLine}.{Environment.NewLine}-end of W3Schools02.cs-{Environment.NewLine}");

  } // end Method
}  // end Class


/* 
you usually want your file to have the same name as its main class.

you can include constructors other than Main, see NLog above, for example.  Constructors must have the same name as the class or struct
Constructors are an active block of code that is defined with an access modifier and optionally some parameters to help with the initialization of the object.
Constructors can call other constructors.  You can call the other constructors by use the : this() method suffix.  
e.g.  public Student(byte age) : this()


The this reference refers to the instance itself.


names of class should use PascalCase, names of parameters, local variables, and private fields should be in camel case (e.g., myVariable), and all other identifiers should be in Pascal case (e.g., MyMethod).


you can pass an array of args as inputs to the Main() method when you start the .cs app from the command line/shell - see:  https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line


You can define a custom value type via struct:  public struct Point { public int X; public int Y; }


Delegates
Just like you can pass in objects to a method via a ref instead of passing their values in by value type, you can also pass in a reference to a method as a ref to it i.e. its object ref:  this is what a delegate is
Parameters passed into the method can ALSO take modifiers to set their interactions with the method. The parameters can be passed both in and OUT as well as by value and by reference into the method. 
The pointer to the method is called a Delegate and allows us to call the method from another location
Delegates are sometimes referred to as Callback Functions
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/


A method declared with a static modifier is a static method. A static method doesn't operate on a specific instance and can only directly access static members.


default value for bools is false
You can obtain the default value for any type via the default keyword:
Console.WriteLine (default (decimal));   // 0


Enums allow you to define your own Types.  An enum is a collection (similar to an array) of related named constants.  By default, the enum's underlying values start with the value 0 and increment by 1


Operators, list of all of them
e.g.   ?.  ~   ^   ?:   <<=   
https://learning.oreilly.com/library/view/c-10-in/9781098121945/ch02.html#operator_precedence_and_associativity:~:text=to%20x.-,Operator%20Table,-Table%C2%A02%2D3


Types not defined in any namespace are said to reside in the global namespace.  The global namespace includes top-level namespaces.
'global using' directives must precede nonglobal directives and cannot appear inside namespace declarations. 

Namespaces can be heirarchically nested 
    e.g.  namespace Outer.Middle.Inner

file-scoped namespacing, applies to everything that follows in the file:
   namespace MyNamespace; 
    class Class1 {}         // inside MyNamespace
    class Class2 {}         // inside MyNamespace

A using directive can be nested within a namespace itself to limit the scope of the directive.


Class inheritance
When a class declares a base class, it inherits all the members of the base class except the constructors. 

A class can directly implement one or more interfaces

Interfaces define behaviors that a class or a struct MUST implement. An interface can contain methods, properties, events and indexers. They can also contain static methods with an implementation.
>Interfaces have no scope.  Are Public by default.
>see:  https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces
>You can't create an instance of an Interface.
see 54min mark of Fritz's ep08 @ https://youtu.be/Vj3GJTUaIaQ


manually add these in every .csproj files:
<nullable>enable</nullable>
<ImplicitUsings>enable</ImplicitUsings>
<CheckForOverflowUnderflow>true</CheckForOverflowUnderflow>
<AllowUnsafeBlocks>true</AllowUnsafeBlocks>
<LangVersion>latest</LangVersion>

*/