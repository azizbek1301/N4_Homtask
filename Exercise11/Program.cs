List<int> numbers = new List<int>();
numbers.Add(5);
numbers.Add(7);
numbers.Add(13);
numbers.Add(24);
numbers.Add(6);
numbers.Add(9);
numbers.Add(8);
numbers.Add(7);


Console.Write("----------------------------------------------\n");


foreach (var lstnum in numbers)
{
    Console.WriteLine(lstnum + " ");
}

Console.Write("Nechta son olish kerak? : ");
int n = Convert.ToInt32(Console.ReadLine());

numbers.Sort();
numbers.Reverse();
var result=numbers.Take(n);
Console.Write("Bizga kerak {0} ta son : \n", n);
foreach (int top in result)
{
    Console.WriteLine(top);
}