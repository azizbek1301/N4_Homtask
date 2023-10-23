

string soz;
soz=Console.ReadLine();

var repeatCharacters = soz.GroupBy(x => x);
foreach (var character in repeatCharacters)
{
    Console.WriteLine($"{character.Key} dan {character.Count()} marta takrorlangan");
}

Console.WriteLine("\n-------------------------------");

var querySyntax = from character in soz
                  group character by character into takror
                  select takror;
foreach (var item in querySyntax)
{
    Console.WriteLine($"{item.Key} dan {item.Count()} ta ");
}