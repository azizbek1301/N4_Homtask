
string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

var methodSyntax=dayWeek.Select(x => x);
foreach (var item in methodSyntax)
{
    Console.WriteLine(item);
}
Console.WriteLine("\n-------------------------");

var querySyntax=from day in dayWeek
                select day;
foreach (var item in querySyntax)
{
    Console.WriteLine(item);
}