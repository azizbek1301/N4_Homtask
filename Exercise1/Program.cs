
var numbers = new int[7] { 1, 5, 6, 8, 12, 3,54 };


var methodResult=numbers.Where(x=>x%2==0);

foreach(var number in methodResult)
{
    Console.Write(number+" ");
}

Console.WriteLine("\n--------------------");

var queryResult=from number in numbers
                where number%2==0 
                select number;
foreach (var number in queryResult)
{
    Console.Write(number+" ");
}