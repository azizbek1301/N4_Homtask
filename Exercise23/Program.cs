

char[] charset1 = { 'X', 'Y', 'Z' };
int[] numset1 = { 1, 2, 3, 4 };

var result = from letterList in charset1
                       from numberList in numset1
                       select new { letterList, numberList };


foreach (var Item in result)
{
    Console.WriteLine(Item);
}


