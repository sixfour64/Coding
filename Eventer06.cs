// Eventer06.cs

/* 
launch string in the .replit:
dotnet --info && dotnet --list-runtimes && dotnet --list-sdks && dotnet --version && dotnet run --project /home/runner/codeBasics0102/Eventer06.csproj
*/

namespace Coding;
  
class Eventer06 
  {
  public static void Main (string[] args) 
  {
    Console.WriteLine ("\n.\nHello World 6 - Eventer06.cs"); 

DateTime dat1 = DateTime.Now;
string dat2 = DateTime.Now.ToString ("dd-MM-yyyy  hh:mm:ss");
    Console.WriteLine($".{Environment.NewLine}Current Time Zone: {TimeZoneInfo.Local.DisplayName}");
Console.WriteLine($"DateTime.Now {{dat1}} is: {dat1}.  \nstring {{dat2}} = DateTime.Now.ToString (\"dd-MM-yyyy  hh:mm:ss\") is: {dat2}");

DateTime dat3 = DateTime.Now;
string dat4 = dat3.ToString ("dd-MM-yyyy  hh:mm:ss");
Console.WriteLine($"System Time Zone's DateTime.Now =  {dat4} {Environment.NewLine} TimeZoneInfo.Local.DisplayName: {TimeZoneInfo.Local.DisplayName}{Environment.NewLine}TimeZoneInfo.Local.StandardName: {TimeZoneInfo.Local.StandardName}");

string displayName = "(GMT+10:00) Pacific/Port_Moresby";
string standardName = "GMTten";
TimeSpan offset = new TimeSpan(10, 00, 00);
TimeZoneInfo GMTten = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
Console.WriteLine(".\nThe converted-to-local current time is {0} named: {1}\n.",
TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, GMTten), GMTten.StandardName);


Console.WriteLine($"{Environment.NewLine}.{Environment.NewLine}-end of Eventer06.cs-{Environment.NewLine}");  

} // end Method
}  // end Class

/*

An event is declared like a field except that the declaration includes an event keyword and the type must be a delegate type.
      
*/