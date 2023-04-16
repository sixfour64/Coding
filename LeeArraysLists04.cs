/*
LeeArraysLists04.cs

rm -r "/home/runner/Coding/obj/" && rm -r "/home/runner/Coding/bin/"
dotnet run --project "/home/runner/Coding/Coding01.csproj"

launch string in the .replit:
dotnet --info && dotnet --list-runtimes && dotnet --list-sdks && dotnet --version && dotnet sdk check && dotnet run --project /home/runner/Coding/LeeArraysLists04.csproj

dotnet run --project /home/runner/Coding/LeeArraysLists04.csproj

*/

using System.Collections;

namespace Coding;

  class LeeArraysLists04
  {
    static void Main(string[] args)
    {
Console.WriteLine($"{Environment.NewLine}Hello LeeArraysLists04.cs{Environment.NewLine}");
      
DateTime dat1 = DateTime.Now;
string dat2 = DateTime.Now.ToString ("dd-MM-yyyy  hh:mm:ss");
Console.WriteLine($".{Environment.NewLine}Current Time Zone: {TimeZoneInfo.Local.DisplayName}");
Console.WriteLine($"DateTime.Now {{dat1}} is: {dat1}.  \nstring {{dat2}} = DateTime.Now.ToString (\"dd-MM-yyyy  hh:mm:ss\") is: {dat2}");

DateTime dat3 = DateTime.Now;
string dat4 = dat3.ToString ("dd-MM-yyyy  hh:mm:ss");
Console.WriteLine($"System Time Zone's DateTime.Now =  {dat4} {Environment.NewLine} TimeZoneInfo.Local.DisplayName: {TimeZoneInfo.Local.DisplayName}{Environment.NewLine}TimeZoneInfo.Local.StandardName: {TimeZoneInfo.Local.StandardName} {Environment.NewLine}.");

 

// as a Rectangular array
int[,] matrixRect = new int[4,5];  //  4 rows each with 5 columns
for (int i = 0; i < matrixRect.GetLength(0); i++)
  for (int j = 0; j < matrixRect.GetLength(1); j++)
    matrixRect[i,j] = i * 5 + j;
      
// as a jagged array:  int[][] matrixRect = new int[3][];
Console.WriteLine($"matrixRect[3,0] is: {matrixRect[3,0]}");
Console.WriteLine($"matrixRect[3,4] is: {matrixRect[3,4]}");
Console.WriteLine($"matrixRect.GetLength(0) is: {matrixRect.GetLength(0)}");
Console.WriteLine($"matrixRect.GetLength(1): {matrixRect.GetLength(1)}");
Console.WriteLine($"matrixRect.Length is: {matrixRect.Length}");
// 2 ways using foreach to list out array's members
foreach (int k in matrixRect){
  System.Console.Write("{0}. ", k);
  }

      
// pick out one index member by using ref then write it on console
 ref int lRef = ref matrixRect[2,3];
System.Console.WriteLine($"{Environment.NewLine}lref rowIndex2,colIndex3  {lRef} <-pick out one index member by using ref then write it on console");

      
var namesListOf = new List<string> { "dude", "Ana", "Felipe" };
// You specify the type of the elements in the List<T> between the angle brackets.
// List<T> type can grow or shrink via add remove
// The List<T> enables you to reference individual items by index as well. You access items using the [ and ] tokens.

Console.WriteLine("\n.\nCapacity: {0}", namesListOf.Capacity);
Console.WriteLine("Count: {0}", namesListOf.Count);

//  use foreach when you want to interact with a collection of values, things
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

// use an Indexer as another way of writing to screen the index number of a List element
for (int i = 0; i < namesListOf.Count; i++)
{
    string s = namesListOf[i];
    namesListOf[i] = s.ToUpper();
    Console.Write($"index# {i} "); Console.Write(namesListOf[i]);Console.WriteLine($"");
}

      
namesListOf.Clear();
int Cap = namesListOf.Capacity;
int Cnt = namesListOf.Count;
Console.WriteLine($"{Environment.NewLine}capacity= {Cap}");
Console.WriteLine($"count= {Cnt}{Environment.NewLine}.");

// how out works:  "123" is string then we parse it into an int
bool successful = int.TryParse("123", out int result);
Console.WriteLine($"How out works: {result}, {result + result}{Environment.NewLine}.");

Console.WriteLine($"Factorial(23) is: {Factorial(23)}{Environment.NewLine}.");


// SortedList() is similar to Hashtable()
// both require:  using System.Collections;
var fileExt = new Hashtable();
fileExt.Add("txt", "Plain text");
fileExt.Add("mp3", "Compressed Music");
fileExt.Add("jpg", "Jpeg Compressed Images");
Console.WriteLine("Hashtable key-value pairs:");
foreach (var kv in fileExt) 
{
Console.Write(((DictionaryEntry)kv).Key);Console.Write(" - ");Console.Write(((DictionaryEntry)kv).Value);Console.Write("\t : \t");Console.WriteLine(((DictionaryEntry)kv).GetType());
}
     
/* outputs:
mp3
txt
jpg
*/

      
Console.WriteLine($"{Environment.NewLine}.{Environment.NewLine}-end of LeeArraysLists04.cs-{Environment.NewLine}");



      
      
}  // end method

 
// recursiveness
static decimal Factorial (decimal x)
  {
  if (x == 0) return 1;
  return x * Factorial (x-1);
  } // end method


    
 } // end class


/*
Commonly used collection types:
https://learn.microsoft.com/en-us/dotnet/standard/collections/commonly-used-collection-types

Array types are reference types

The new operator automatically initializes the elements of an array to their default value, which is zero for all numeric types and null for all reference types.
// Declare the array with initial values:
     var fullArrayOfNumbers = new int[3] {1, 2, 3};
     Console.WriteLine("Array Size: " + fullArrayOfNumbers.Length);

for multi-dimensional arrays, see:
https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/features#:~:text=This%20example%20creates,dimensional%20array%2C%20respectively

The foreach statement can be used to enumerate the elements of any collection.   
foreach (int item in a){Console.WriteLine(item);}
Use foreach when you want to interact with a collection of values, things
 The foreach statement is functionally the same as the following for loop with an iterator:
    for (var nameCounter = 0; nameCounter < arrNames.Length; nameCounter++) {
    display(arrNames[nameCounter]);
    }

Stack()
You can mix types stored in a stack, see example at CSharpFritz's ep05 
https://hub.gke2.mybinder.org/user/csharpfritz-csh-ith_csharpfritz-ucsml7v3/notebooks/0105-CollectionsAndGenerics.ipynb#:~:text=We%27ve%20looked%20at%20these%20basic%20interactions%20with%20collection%20types%20and%20the%20keys%20or%20values%20stored%20don%27t%20have%20a%20specific%20type%20associated.%20You%20can%20get%20into%20some%20hairy%20situations%20dealing%20with%20type


A Hashset is a high-performance collection that does not contain duplicate entries.


  */