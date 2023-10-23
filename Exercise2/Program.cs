

int[] numbers = {1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14};

var methodresult = numbers.Where(x => x > 0).Where(x=>x<10);

foreach(var number in methodresult)
{
    Console.Write(number+" ");
}

Console.WriteLine("\n---------------------------");

var methodQuery2 = numbers.Where(x => CheckNumber(x));
foreach(var number in methodQuery2)
{  
    Console.Write(number+" ");
}
static bool CheckNumber(int num)
{
    if(num>0 && num<10)
        return true;
    return false;
}



Console.WriteLine("\n---------------------------");

var querySyntax=from number in numbers
                where number>0
                where number<10
                select number;

foreach (var item in querySyntax)
{
    Console.Write(item+" ");


}
