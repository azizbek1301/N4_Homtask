



using System.Xml.Serialization;


//public class Program
//{
//    public static void Main(string[] args)
//    {
//        var person = new person()
//        {
//            name = "john",
//            age = 22,
//            city = "new york",
//        };
//        Console.WriteLine();
//        var serializer = new XmlSerializer(typeof(person));
//        using (TextWriter writer = new StringWriter())
//        {
//            serializer.Serialize(writer, person);
//            string xml = writer.ToString();
//            Console.WriteLine("xml ma'lumot" + " " + xml);
//        }

//    }
//}




// Xml dan objectga o'tish


//string xml = @"
//            <person >
//                 < name > john </ name >
//                 < age > 22 </ age >
//                 < city > new york</ city >
//             </ person >";

//var serializer1=new XmlSerializer(typeof(person));
//using(TextReader reader=new StreamReader(xml))
//{
//    var person1 = (person)serializer1.Deserialize(reader);
//    Console.WriteLine("Name "+person1.name);
//    Console.WriteLine("age "+person1.age);
//Console.WriteLine("city " + person1.city);
//}
public class Person
{
    public string name { get; set; }
    public int age { get; set; }
    public string city { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        string xml = @"
                <Person>
                    <name>john</name>
                    <age>22</age >
                    <city>new york</city>
                </Person>";

        var serializer=new XmlSerializer(typeof(Person));
        using(TextReader reader = new StringReader(xml))
        {
            var personObj=(Person)serializer.Deserialize(reader);

            Console.WriteLine("Name " + personObj.name);
            Console.WriteLine("age "+personObj.age);
            Console.WriteLine("city " + personObj.city);
        }
    }
}



