// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time
DateTime now = DateTime.Now;
Console.WriteLine($"The time is {now}");

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
DateTime today = DateTime.Today;
Console.WriteLine($"The date is {today}");

// TODO: DateOnly and TimeOnly represent just dates and times
DateOnly dt = DateOnly.FromDateTime(now);
TimeOnly tm = TimeOnly.FromDateTime(now);
Console.WriteLine($"The date is {dt}");
Console.WriteLine($"The time is {tm}");

// TODO: Dates have properties that can be inspected
Console.WriteLine(today.DayOfWeek);
Console.WriteLine(today.DayOfYear);

// TODO: Dates also have methods to change their values
now = now.AddDays(2);
now = now.AddMonths(1);
now = now.AddHours(8);
Console.WriteLine($"The new date is {now}");

// TODO: The TimeSpan class represents a duration of time
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);
TimeSpan interval = AprilFools - NewYears;
Console.WriteLine($"There are {interval.TotalDays} days between New Years and April Fools");

// TODO: Dates can be compared using regular operators
Console.WriteLine($"{NewYears < AprilFools} {NewYears > AprilFools} {NewYears == AprilFools}");

