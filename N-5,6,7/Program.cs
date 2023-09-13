


// TAsk N1  Ism bosh harfini konsolda chiqarish

char[,] arr = new char[6, 11];

for (int i = 0; i < 6; i++)
{
   
        arr[i, 5 - i] = '*';
        arr[i, 5 + i] = '*';
        if(i==3)
        {
            for(int k=2; k<9;k++)
            {
                arr[i, k] = '*';
            }
        }
    
}


for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 11; j++)
    {
        Console.Write(arr[i,j]+"\t");
    }
    Console.WriteLine();
}


// Task 2  Palindrom sonni tekshirish

Console.WriteLine("Son kiritng ");
int son=int.Parse(Console.ReadLine());
int copySon = son;
string yangiSon=string.Empty;

while(son>0)
{
    yangiSon += son % 10;
    son /= 10;
}

int result = Int32.Parse(yangiSon);
if(result==copySon)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}


// Task N3 Berilgan sonni boshqa o'zgaruvchiga teskari o'zlashtirish

Console.WriteLine("Son kiritng ");
int number = int.Parse(Console.ReadLine());

string newNumber = string.Empty;

while (number > 0)
{
    newNumber += number % 10;
    number /= 10;
}

int result1 = Int32.Parse(newNumber);
Console.WriteLine(result1);



// Task 4 Romb Chizish
Console.WriteLine("Romb o'lchamini kiriting:");
int romb=int.Parse(Console.ReadLine());
int count = 1;
for (int j=0; j < romb-1; j++)
{
    Console.Write(new string(' ',romb-count));
    for (int i=0; i < count;i++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
    count++;
}
for(int i = 0; i < romb; i++)
{
    Console.Write("* ");
}
Console.WriteLine();
count = romb-1;
for (int j = 0; j < romb - 1; j++)
{
    Console.Write(new string(' ', romb - count));
    for (int i = 0; i < count; i++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
    count--;
}