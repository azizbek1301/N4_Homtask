
var arr1 = new int[] { 9,5,5, 9, 1,2,2,2,2,4,5,6,7,8,9, 2, 3, 7,7,7,1,7,7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

var repeatNumbers = arr1.GroupBy(x => x);
foreach (var repeatNumber in repeatNumbers)
{
    Console.WriteLine($"{repeatNumber.Key} dan {repeatNumber.Count()} marta takrorlangan");
}

Console.WriteLine("\n-------------------------------");

var querySyntax = from number in arr1
                  group number by number into takror
                  select takror;
foreach (var item in querySyntax)
{
    Console.WriteLine($"{item.Key} dan {item.Count()} ta ");
}

