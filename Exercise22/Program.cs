

string[] arr1;
int n, i, ctr;



n = Convert.ToInt32(Console.ReadLine());
arr1 = new string[n];

for (i = 0; i < n; i++)
{
    Console.Write("Element[{0}] : ", i);
    arr1[i] = Console.ReadLine();
}

Console.Write("\nEng kichik o'lchamni kiriting : ");
ctr = Convert.ToInt32(Console.ReadLine());

IEnumerable<string> objNew = from m in arr1
                             where m.Length >= ctr
                             orderby m
                             select m;

foreach (string z in objNew)
    Console.WriteLine("Item: {0}", z);