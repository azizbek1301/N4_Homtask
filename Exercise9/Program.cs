

var numbers=new List<int>();

numbers.Add(50);
numbers.Add(70);
numbers.Add(58);
numbers.Add(85);
numbers.Add(90);
numbers.Add(1000);
numbers.Add(120);
numbers.Add(230);
numbers.Add(450);
numbers.Add(82);

foreach (var number in numbers)
{
    Console.Write(number+" ");
}

Console.WriteLine("\n80 dan kattalari");

var result = numbers.Where(x => x > 80);

foreach (var item in result)
{
    Console.Write(item+" ");
}

Console.WriteLine("\n Ikkinchi usul");

var resukt2 = numbers.FindAll(x => x > 80 ? true : false);

foreach (var item in resukt2)
{
    Console.Write(item+" ");
}