
var array = new[] {1,3,8,7,20,14,20,3,69,45};

var methodSyntax = array.Select(x => x * x);
foreach (var item in methodSyntax)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n----------------");

var querySyntax = (from number in array
                  let kvadrat = Math.Pow(number,2)
                  select new { number, kvadrat }).ToList();

foreach (var item in querySyntax)
{
    Console.WriteLine(item);
}