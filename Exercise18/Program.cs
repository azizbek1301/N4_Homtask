List<string> listOfString = new List<string>();
listOfString.Add("m");
listOfString.Add("n");
listOfString.Add("o");
listOfString.Add("p");
listOfString.Add("q");





var result1 = from y in listOfString
              select y;
Console.Write("Here is the list of items : \n");
foreach (var tchar in result1)
{
    Console.WriteLine("Char: {0} ", tchar);
}
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
string newstr = listOfString.FirstOrDefault(en => en == "p");
listOfString.Remove(newstr);


var result = from z in listOfString
             select z;

foreach (var rChar in result)
{
    Console.WriteLine("Char: {0} ", rChar);
}