// See https://aka.ms/new-console-template for more information
var date = DateTime.Now;

DateTime today = DateTime.Today;
DateTime nextChristmas = new DateTime(today.Year, 12, 25);

Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {date:MM-dd-yyyy} {date:HH:mm:ss}");
Console.WriteLine($"There are {(nextChristmas - today).Days} days until christmas");