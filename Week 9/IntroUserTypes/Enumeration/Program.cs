﻿// Code examples using enumerations in C#
// For more information on enumerations see:
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum

using Enumeration;

// Enumerations used here are defined in Enums.cs file 
Console.WriteLine("Example of simple C# enumerations");

// Declare an instance of DaysWeek
Days today = Days.Tuesday;

// Prints "Today is Tuesday"
Console.WriteLine($"Today is {today}");

// Does this work? If so why? How?
Days tomorrow = today + 1;
Console.WriteLine($"Tomorrow is {tomorrow}");

// Prints the value 1 for Monday
Console.WriteLine("Monday has the numeric value of {0}",
    Convert.ToInt32(Days.Monday));
// Prints the value 3 for Wednesday
Console.WriteLine("Wednesday has the numeric value of {0}", 
    Convert.ToInt32(Days.Wednesday));

Console.WriteLine(MeetingsDays.Weekend);

MeetingsDays meetingDays = MeetingsDays.Monday | MeetingsDays.Wednesday | MeetingsDays.Friday;
Console.WriteLine(meetingDays);

bool isMeetingOnWednesday = (meetingDays & MeetingsDays.Wednesday) == MeetingsDays.Wednesday;
Console.WriteLine($"Is there a meeting on a Wedesay: {isMeetingOnWednesday}");

bool isTodayWeekend = (MeetingsDays.Thursday == MeetingsDays.Weekend);
Console.WriteLine($"Is it the weekend yet? : {isTodayWeekend}");
