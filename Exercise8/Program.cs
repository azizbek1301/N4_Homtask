

string StartCh, EndCh;

char ch;
ch=(char)Console.Read();
StartCh = ch.ToString();
ch=(char)Console.Read();
EndCh = ch.ToString();

string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

var methodSyntax = cities.Select(x => x).Where(x => x.StartsWith(StartCh)).Where(x=>x.EndsWith(EndCh));

foreach (var method in methodSyntax)
{
    Console.WriteLine(method);
}