

using N11;

// Dictionary

Dictionary<int, string> keyValuePairs = new Dictionary<int, string>()
{
    {3,"uch" },
    {5,"besh" },
    {1,"bir" }
};

var myDict=keyValuePairs.OrderBy(k=>k.Key).ToList();

foreach(var kv in myDict)
{
    Console.WriteLine("Key: {0} , Value: {1}", kv.Key, kv.Value);
}

// SortedList
SortedList<string, string> qiymat = new SortedList<string, string>()
{
    {"UZS","Sum" },
    {"USD","Dollar" },
    {"XSU","Rubl" },
    {"AUD","External Dollar" },

};
string value;
qiymat.Remove("XSU", out value);
Console.WriteLine(value);

var mySortedValues=qiymat.OrderBy(x => x.Key).ToList();
var myValue=qiymat.OrderByDescending(x => x.Key).ToList();


foreach (var item in mySortedValues)
{
    Console.WriteLine("Key: {0}, Value {1}", item.Key, item.Value);
}
Console.WriteLine("-----------------------------------------");
foreach (var item in myValue)
{
    Console.WriteLine("Key: {0}, Value {1}", item.Key, item.Value);
}


Number<int, int> numbers = new Number<int, int>();
Console.WriteLine(numbers.Add(25, 35));


Number<string, string> numbers1 = new Number<string, string>();
Console.WriteLine(numbers1.Add("Azizbek ", "Rahmatullayev"));



GenericCollection<Person> result = new GenericCollection<Person>();
string obyekt = result.Add(new Person { Id = 4, Name = "Ali" }).Name;

Console.WriteLine(obyekt);
class GenericCollection<Tsource>
{
    public Tsource Add(Tsource x)
    {
        return x;
    }
}


class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}



