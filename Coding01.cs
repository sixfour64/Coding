// Coding01.cs

/* 
launch string in the .replit:
dotnet --info && dotnet --list-runtimes && dotnet --list-sdks && dotnet --version && dotnet sdk check && dotnet run --project /home/runner/Coding/Coding01.csproj

dotnet run --project /home/runner/Coding/Coding01.csproj
   if in GitHub CodeSpaces:
     dotnet run --project Coding01.csproj

*/

using Humanizer;
using Microsoft.EntityFrameworkCore;

namespace Coding;

class Coding01 {
  public static void Main (string[] args) {
    Console.WriteLine ("\n.\nHello World 1 - Coding01.cs");
    Console.WriteLine ($"{3501.ToWords()}");  // inflector method from Humanizer package

DateTime dat1 = DateTime.Now;
string dat2 = DateTime.Now.ToString ("dd-MM-yyyy  hh:mm:ss");
    Console.WriteLine($".{Environment.NewLine}Current Time Zone: {TimeZoneInfo.Local.DisplayName}");
Console.WriteLine($"DateTime.Now {{dat1}} is: {dat1}.  \nstring {{dat2}} = DateTime.Now.ToString (\"dd-MM-yyyy  hh:mm:ss\") is: {dat2}");

DateTime dat3 = DateTime.Now;
string dat4 = dat3.ToString ("dd-MM-yyyy  hh:mm:ss");
Console.WriteLine($"System Time Zone's DateTime.Now =  {dat4} {Environment.NewLine} TimeZoneInfo.Local.DisplayName: {TimeZoneInfo.Local.DisplayName}{Environment.NewLine}TimeZoneInfo.Local.StandardName: {TimeZoneInfo.Local.StandardName} {Environment.NewLine}.");

   

/*  outputs:
.
DateTime.Now {dat1} is: 3/28/2023 5:36:38 AM.  
string {dat2} = DateTime.Now.ToString ("dd-MM-yyyy  hh:mm:ss") is: 28-03-2023  05:36:38
*/

Console.WriteLine("\n.\nCurrent code page: {0}\n",
Console.OutputEncoding.CodePage);  
  
  int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is int.MinValue {min} to int.MaxValue {max}\n.");
int whatmax = max + 11;
int whatmin = min - 11;
Console.WriteLine($"An example of -ve overflow: {whatmin}");
Console.WriteLine($"An example of +ve overflow: {whatmax}\n.");

// outputs:
// The range of integers is int.MinValue -2147483648 to int.MaxValue 2147483647
// .
// An example of -ve overflow: 2147483637
// An example of +ve overflow: -2147483638
// .


// ++++++++++

decimal a = 19M;
decimal b = 23M;
decimal c = 9M;
decimal d = (a + b) / c;
Console.WriteLine($"decimal: {d}");

// outputs:  decimal: 4.6666666666666666666666666667

// decimal x = 1.0M;
// The M suffix on the numbers is how you indicate that a constant should use the decimal type. Otherwise, the compiler assumes the double type.
// You can use either a lower-case m or upper-case M as the literal suffix for a decimal.



double e = 19;
double f = 23;
double g = 9.137137137137137;
double h = (e + f) / g;
Console.WriteLine($"double: {h} <-limited to 14 decimal places\n.");

// outputs:
// double: 4.59662576687117 <-limited to 14 decimal places


// ++++++++++++++++++++++++


double doubthird = 1.0 / 3.0;
Console.WriteLine($"{doubthird}  native as double");

double decthird = 1.0 / 3.0;
decimal dec;
dec = (decimal) decthird;
Console.WriteLine($"{decthird}  cast to decimal");

double longthird = 1.0 / 3.0;
long lng;
lng = (long) longthird;
Console.WriteLine($"{longthird}  cast to long\n.");

// outputs:
// 0.333333333333333  native as double
// 0.333333333333333  cast to decimal
// 0.333333333333333  cast to long

// casting int to decimal, escape chars on console output.  a cast operation only temporarily treats a value as if it were a different data type
int first = 13;
int second = 7;
decimal quotientdec = (decimal)first / (decimal)second;
double quotientdou = (double)first / (double)second;
Console.WriteLine($"int of {{first}} is {first};  int of {{second}} is {second}");
Console.WriteLine($"quotient of first//second after int cast to decimal: {quotientdec}");
Console.WriteLine($"quotient of first//second after int cast to double: {quotientdou}");
Console.WriteLine($"{{first}} mod {{second}} is {{first%second}} or {first%second}");

/* outputs:
int of {first} is 13;  int of {second} is 7
quotient of first//second after int cast to decimal: 1.8571428571428571428571428571
quotient of first//second after int cast to double: 1.85714285714286
{first} mod {second} is {first%second} or 6
*/



// ++++++++++++++++

int max2 = int.MaxValue;
int min2 = int.MinValue;
Console.WriteLine($"The range of integers is int.MinValue {min2} to int.MaxValue {max2}");

float fmin = float.MinValue;
float fmax = float.MaxValue;
Console.WriteLine($"The range of float is float.MinValue {fmin} to float.MaxValue {fmax}");

double dmin = Double.MinValue;
double dmax = Double.MaxValue;
Console.WriteLine($"The range of double is Double.MinValue {dmin} to Double.MaxValue {dmax}");

decimal emax = decimal.MaxValue;
decimal emin = decimal.MinValue;
Console.WriteLine($"The range of decimal is decimal.MinValue {emin} to decimal.MaxValue {emax}");

short shmin = short.MinValue;
short shmax = short.MaxValue;
Console.WriteLine($"The range of short is short.MinValue {shmin} to short.MaxValue {shmax}");

long lmin = long.MinValue;
long lmax = long.MaxValue;
Console.WriteLine($"The range of long is long.MinValue {lmin} to long.MaxValue {lmax}");

Console.WriteLine($"There is also byte and sbyte which use only 8bits 0-127");
Console.WriteLine($"There is also native ints ninit and nuint{Environment.NewLine}.");

Console.WriteLine (        1.0.GetType());  // Double  (double)
Console.WriteLine (       1E06.GetType());  // Double  (double)
Console.WriteLine (          1.GetType());  // Int32   (int)
Console.WriteLine ( 0xF0000000.GetType());  // UInt32  (uint)
Console.WriteLine (0x100000000.GetType());  // Int64   (long)
    

// outputs:
// The range of integers is int.MinValue -2147483648 to int.MaxValue 2147483647
// The range of float is float.MinValue -3.402823E+38 to float.MaxValue 3.402823E+38
// The range of double is Double.MinValue -1.79769313486232E+308 to Double.MaxValue 1.79769313486232E+308
// The range of decimal is decimal.MinValue -79228162514264337593543950335 to decimal.MaxValue 79228162514264337593543950335
// The range of short is short.MinValue -32768 to short.MaxValue 32767
// The range of long is long.MinValue -9223372036854775808 to long.MaxValue 9223372036854775807
// .
// +++++++++++++++

int a2 = 7;
int b2 = 4;
int c2 = 3;
int d2 = (a2 + b2) / c2;
Console.WriteLine($"int {d2}");
float e2 = 7;
float f2 = 4;
float g2 = 3;
float h2 = (e2 + f2) / g2;
Console.WriteLine($"float {h2}");
double i2 = 7;
double j2 = 4;
double k2 = 3;
double l2 = (i2+j2) / k2;
Console.WriteLine($"double {l2}");
decimal m2 = 7;
decimal n2 = 4;
decimal o2 = 3;
decimal p2 = (m2+n2) / o2;
Console.WriteLine($"decimal {p2}");
long q2 = 7;
long r2 = 4;
long s2 = 3;
long t2 = (q2+r2) / s2;
Console.WriteLine($"long {t2}\n.");

// outputs:
// int 3
// float 3.666667
// double 3.66666666666667
// decimal 3.6666666666666666666666666667
// long 3


// ++++++++++++++++++++


int a3 = 7;
int b3 = 4;
int c3 = 3;
int d3 = (a3 + b3) / c3;
int e3 = (a3 + b3) % c3;
int f3=a3+b3;
Console.WriteLine($"int quotient: {d3}");
Console.WriteLine($"int remainder: {e3}");
Console.WriteLine($"int fractional: {e3/f3}");
Console.WriteLine($"int fractional: {e3/c3}");
decimal g3 = 7;
decimal h3 = 4;
decimal i3 = 3;
decimal j3 = (g3+h3) / i3;
decimal k3 = (g3+h3) % i3;
decimal l3=g3+h3;
Console.WriteLine($"decimal quotient: {j3}");
Console.WriteLine($"decimal remainder: {k3}");
Console.WriteLine($"decimal fractional: {k3/l3}");
Console.WriteLine($"decimal fractional: {k3/i3}");

// outputs:
// int quotient: 3
// int remainder: 2
// int fractional: 0
// int fractional: 0
// decimal quotient: 3.6666666666666666666666666667
// decimal remainder: 2
// decimal fractional: 0.1818181818181818181818181818
// decimal fractional: 0.6666666666666666666666666667


// ++++++++++++++++++++++++

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
var JP = "Japanese";
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write ($"{JP} {Environment.NewLine}  \u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092 {Environment.NewLine}\t={Environment.NewLine}  \u751f\u6210\u3059\u308b\u306b\u306f  \uff1a\n");
// User command to run an application
  
Console.WriteLine(@"   c:\invoices\app.exe -j");

var newL = string.Format("Add a{0}new line{0}.", Environment.NewLine);
Console.WriteLine(newL);
// The advantage here is writing {0} every time we need a line break. 

/*outputs:
こんにちは World!
Japanese 
  日本の請求書を 
	=
  生成するには  ：
   c:\invoices\app.exe -j
Add a
new line.
*/


// ++++++++++++++++++++++++

object obj = "object obj";
Type obj1 = typeof(object); // ==> object
Type obj2 = obj.GetType();  // ==> string!
Console.WriteLine($"{Environment.NewLine}{obj}\t obj1 is {obj1}");
Console.WriteLine($"\t\t\t obj2 is {obj2}");
Console.WriteLine($"typeof(object) refers to the compile-time container{Environment.NewLine}obj.GetType() refers to the run-time contents of that container{Environment.NewLine}.");

Console.WriteLine("how to force columnar blank spaces on a line");
Console.WriteLine("{0,-31}{1,-47}{2,-25}", "PROPERTY", "INTERNATIONAL", "TRADITIONAL");
Console.WriteLine("{0,-31}{1,-47}{2,-25}", "col 1", "col 2", "col 3");
    
 Console.WriteLine($".{Environment.NewLine}-end of Coding01.cs-{Environment.NewLine}");

/*  outputs:
object obj	 obj1 is System.Object
obj2 is System.String
typeof(object) refers to the compile-time container
obj.GetType() refers to the run-time contents of that container
*/


  } // end Method
}  // end Class



/*  

Use vscode.dev for quick edits online  GitHub, Azure Repos, and local files.  https://vscode.dev/
browser Extensions for Visual Studio Code @ https://marketplace.visualstudio.com/vscode

-start the online IDE via:  https://www.w3schools.com/cs/cs_compiler.php


Videos:
-video lessons:  https://learn.microsoft.com/en-au/shows/csharp-101/
-video's text chapters to follow along <online version>:  https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/
-video's text chapters to follow along <local to my PC version>: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/arrays-and-collections


-Fritz's 'learn C# with CSharpFritz' youtube playlist of 68 lesson:
https://www.youtube.com/playlist?list=PLdo4fOcmZ0oXv32dOd36UydQYLejKR61R
end of lesson 3 

Coding01 has had:
  https://github.com/Humanizr/Humanizer 
add it as a package:
dotnet add package --help
dotnet add [<PROJECT>] package <PACKAGE_NAME> [options]
dotnet add [<PROJECT>] package Humanizer --version 2.14.1
dotnet add Scratch.csproj package Humanizer --version 2.14.1
see also: 
  https://www.nuget.org/packages/Humanizer#readme-body-tab


NuGet packages:
  dotnet add Coding01.csproj package Microsoft.EntityFrameworkCore
-or-
  add these lines to each .csproj file manually:
    <ItemGroup>
    <PackageReference Include="Humanizer" Version="2.14.1" />
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="7.0.5" />
   </ItemGroup>


To list out what Packages each project has installed:
  dotnet list /workspaces/Coding/Eventer06.csproj package && dotnet list /workspaces/Coding/LeeArraysLists04.csproj package && dotnet list /workspaces/Coding/Main.csproj package && dotnet list /workspaces/Coding/Scratch.csproj package && dotnet list /workspaces/Coding/TimeZones05.csproj package && dotnet list /workspaces/Coding/W3Schools02.csproj package


Manually resore one of my GitHub Codespaces projects:
  dotnet restore Coding01.csproj --verbosity detailed

View Nuget folders and env variables:
  

valid dotnet commands:
  dotnet build                           compiles without building
  dotnet restore
  dotnet list <PROJECT> package
  dotnet --info
  dotnet run --project Coding01.csproj
  dotnet new sln                       have your cursor in project's parent folder



*/