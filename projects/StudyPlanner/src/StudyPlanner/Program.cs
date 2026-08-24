// See https://aka.ms/new-console-template for more information
using StudyPlanner;

var tracker = new StudyTracker();

tracker.AddSession("System design", 30);
tracker.AddSession("Unit testing", 25);

Console.WriteLine("Study Planner");
Console.WriteLine("-------------");

foreach (var session in tracker.Sessions)
{
    Console.WriteLine($"{session.Topic}: {session.Minutes} minutes");
}

Console.WriteLine($"Total: {tracker.TotalMinutes} minutes");
