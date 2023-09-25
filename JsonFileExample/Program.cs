

using Newtonsoft.Json;
//using System.Reflection.Metadata;


//User user = new User()
//{
//    Id = 1,
//    Name="Azizbek",
//    Password="123456",
//    Email="azizbek@gmail.com",

//};

//Student student = new Student()
//{
//    User=user,
//    Phone="+9989658",
//    Address="Tashkent",
//};

//string json=JsonConvert.SerializeObject(student,Formatting.Indented);
//Console.WriteLine(json);
//class User
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public string Password {  get; set; }
//    public string Email {  get; set; }
//}

//class Student
//{
//    public User User { get; set; }
//    public string Phone { get; set; }
//    public string Address { get; set; }

//}


Birnima birnima = new Birnima()
{
    Id = 1,
    UserName = "Test",
    Email = "Test",
    Address =new Address()
    {
        Street="Baker",
        Suit="dfdwf",
        City="sds",
        Zipcode="dfsdf",
        geo=new Geo()
        {
            lat="fegr",
            lng="dsff",


        },
    },
    Phone="dd",
    WebSite="dfsdf",
    Company =new Company()
    {
        Name = "Test",
        CatchPhraze="wdfwfw",
        Bs="dwd",
    },
};
string json=JsonConvert.SerializeObject(birnima,Formatting.Indented);
Console.WriteLine(json);

class Birnima
{
    public int Id { get; set; }
    public string UserName {  get; set; }
    public string Email {  get; set; }
    public Address Address { get; set; }
    public string Phone {  get; set; }
    public string WebSite {  get; set; }
    public Company Company { get; set; }

}
class Address
{
    public string Street { get; set; }
    public string Suit {  get; set; }
    public string City { get; set; }
    public string Zipcode {  get; set; }
    public Geo geo { get; set; }
}
class Geo
{
    public string lat { get; set; }
    public string lng { get; set; }
}
class Company
{
    public string Name { get; set; }
    public string CatchPhraze {  get; set; }
    public string Bs { get; set; }
}

