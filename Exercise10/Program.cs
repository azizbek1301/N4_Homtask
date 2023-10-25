

int number, soni, chegara;

soni=int.Parse(Console.ReadLine());

var numbers=new List<int>();

for(var i=0;i<soni;i++)
{
    Console.Write("number {0} : ", i);
    number= int.Parse(Console.ReadLine());
    numbers.Add(number);
}

Console.WriteLine("\n Nechchidan kattalari chiqsin");

chegara=Convert.ToInt32(Console.ReadLine());

var result=numbers.FindAll(x=>x>chegara?true:false);
foreach(var item in result)
{
    Console.Write(item+" ");
}