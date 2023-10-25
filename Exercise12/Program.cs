
string matn;

Console.Write("Yangi matn kiriting : ");
matn = Console.ReadLine();

var result = WordFilt(matn);
Console.Write("\nThe UPPER CASE words are :\n ");
foreach (string str in result)
{
    Console.WriteLine(str);
}
Console.ReadLine();
static IEnumerable<string> WordFilt(string matn)
{
    var kattaSozlar = matn.Split(' ')
                .Where(x =>String.Equals(x, x.ToUpper(),
                StringComparison.Ordinal));

    return kattaSozlar;

}
