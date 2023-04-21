using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading;  // required for 'The two CultureInfo objects'

// TimeZones05.cs

/* 
launch string in the .replit:
dotnet --info && dotnet --list-runtimes && dotnet --list-sdks && dotnet --version && dotnet sdk check && dotnet run --project /home/runner/Coding/TimeZones05.csproj

dotnet run --project /home/runner/Coding/TimeZones05.csproj
   if in GitHub CodeSpaces:
     dotnet run --project TimeZones05.csproj

*/

namespace Coding;
  
class TimeZones05 
  {
  public static void Main (string[] args) 
  {
    Console.WriteLine ("\n.\nHello World 5 - TimeZones05.cs\n."); 


DateTime dat1 = DateTime.Now;
string dat2 = DateTime.Now.ToString ("dd-MM-yyyy  hh:mm:ss");

// Retrieve a CultureInfo object.
CultureInfo invC = CultureInfo.InvariantCulture;
// Convert the date to a string 
Console.WriteLine(dat1.ToString("r", invC));
    
Console.WriteLine($".{Environment.NewLine}Current Time Zone: {TimeZoneInfo.Local.DisplayName}");
Console.WriteLine($"DateTime.Now {{dat1}} is: {dat1}.  \nstring {{dat2}} = DateTime.Now.ToString (\"dd-MM-yyyy  hh:mm:ss\") is: {dat2}");

DateTime dat3 = DateTime.Now;
string dat4 = dat3.ToString ("dd-MM-yyyy  hh:mm:ss");
Console.WriteLine($"System Time Zone's DateTime.Now =  {dat4} {Environment.NewLine}TimeZoneInfo.Local.DisplayName: {TimeZoneInfo.Local.DisplayName}{Environment.NewLine}TimeZoneInfo.Local.StandardName: {TimeZoneInfo.Local.StandardName} {Environment.NewLine}.");

DateTime myDt;
DateTime localDateTime;
  myDt = DateTime.SpecifyKind(dat1, DateTimeKind.Local);
Console.WriteLine($"DateTimeKind.Local is: {myDt}");
    
localDateTime = myDt.ToLocalTime();
Console.WriteLine($"dat1.ToLocalTime() is: {localDateTime}\n.");


ReadOnlyCollection<TimeZoneInfo> zones = TimeZoneInfo.GetSystemTimeZones();
Console.WriteLine("The local system has the following {0} time zones", zones.Count);
foreach (TimeZoneInfo zone in zones)
   Console.WriteLine(zone.Id);

    
string displayName = "(GMT+10:00) Pacific/Port_Moresby";
string standardName = "GMTten";
TimeSpan offset = new TimeSpan(10, 00, 00);
TimeZoneInfo GMTten = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
Console.WriteLine(".\nThe converted-to-local current time is {0} \tnamed: {1}\n.",
TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, GMTten), GMTten.StandardName);
Console.WriteLine("displayNamed: {0} \t\tstandardNamed: {1}\n.", displayName, standardName);

DateTime timeUtc = DateTime.UtcNow;
DateTime replitTime = TimeZoneInfo.ConvertTimeFromUtc (timeUtc, GMTten);
Console.WriteLine($"TimeZoneInfo.ConvertTimeFromUtc {replitTime}");

CultureInfo culture = new CultureInfo("en-AU");
Console.WriteLine(@$"using CultureInfo(""en-AU"") O   " + replitTime.ToString("O", culture));
Console.WriteLine(@$"using CultureInfo(""en-AU"") F   " + replitTime.ToString("F", culture));
Console.WriteLine(@$"using CultureInfo(""en-AU"") R   " + replitTime.ToString("R", culture) + $"{Environment.NewLine}.");
    
/*
The time zone identifier is a key string that uniquely identifies a particular time zone. On Windows systems, it corresponds to: 
    the subkeys of the HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\Time Zone branch of the registry on Windows systems 
and from:
    the ICU Library on Linux and macOS. 
It can be passed as a parameter to the FindSystemTimeZoneById method to instantiate a TimeZoneInfo object that represents a particular time zone.
*/


CultureInfo culture1 = CultureInfo.CurrentCulture;
CultureInfo culture2 = Thread.CurrentThread.CurrentCulture;
Console.WriteLine("The current culture is {0}", culture1.Name);
Console.WriteLine("The two CultureInfo objects are equal: {0}", culture1 == culture2);
Console.WriteLine(".");




    
// Define times to be converted.
      DateTime[] times = { new DateTime(2010, 1, 1, 0, 1, 0), 
                           new DateTime(2010, 1, 1, 0, 1, 0, DateTimeKind.Utc), 
                           new DateTime(2010, 1, 1, 0, 1, 0, DateTimeKind.Local),                            
                           new DateTime(2010, 11, 6, 23, 30, 0),
                           new DateTime(2010, 11, 7, 2, 30, 0) };
                              
      // Retrieve the time zone for Eastern Standard Time (U.S. and Canada).
      TimeZoneInfo aest; 
      try {
         aest = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Port_Moresby");
      }
      catch (TimeZoneNotFoundException) {
         Console.WriteLine($"Unable to retrieve the {offset} time zone.");
         return;
      }
      catch (InvalidTimeZoneException) {
         Console.WriteLine($"Unable to retrieve the {offset} time zone.");
         return;
      }   

      // Display the current time zone name.
      Console.WriteLine("\n.\nLocal time zone: {0}\n", TimeZoneInfo.Local.DisplayName);
      
      // Convert each time in the array.
      foreach (DateTime timeToConvert in times)
      {
         DateTime targetTime = TimeZoneInfo.ConvertTime(timeToConvert, aest);
         Console.WriteLine("Converted {0} {1} to {2}.", timeToConvert, timeToConvert.Kind, targetTime);
        }


    
Console.WriteLine($"{Environment.NewLine}.{Environment.NewLine}-end of TimeZones05.cs-{Environment.NewLine}");
    
} // end Method
}  // end Class

/*

dotnet add TimeZones05.csproj package Microsoft.EntityFrameworkCore


var TimeLocal = DateTimeOffset.Now;
var TimeLA = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(TimeLocal, "Asia/Magadan");
Console.WriteLine($"local time: {TimeLocal}");
Console.WriteLine($"LA time: {TimeLA}   for Asia/Magadan");

currentDate = DateTime.Parse("2019-11-16T17:25:00Z").ToUniversalTime()
      localDateTime = univDateTime.ToLocalTime();


perhaps besides Humanizer for datetimes, consider using Skeet's NodaTime library @ https://nodatime.org/3.1.x/userguide/index
      
*/