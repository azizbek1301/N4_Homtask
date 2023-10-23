

int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

var repeatNumbers = nums.GroupBy(x => x);

foreach (var number in repeatNumbers)
{
    Console.WriteLine($"{number.Key}    {number.Sum()}   {number.Count()}");
}

Console.WriteLine("\n-------------------------------");

var querySyntax = from number in nums
                  group number by number into takror
                  select takror;
foreach (var number in querySyntax)
{
    Console.WriteLine($"{number.Key}    {number.Sum()}   {number.Count()}");
}

