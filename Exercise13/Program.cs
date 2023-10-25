string[] arr1;
int n, i;

Console.WriteLine(" Massiv elementlari sonini kiriting:  ");
n = Convert.ToInt32(Console.ReadLine());
arr1 = new string[n];
Console.Write("array {0}   :\n", n);
for (i = 0; i < n; i++)
{
    Console.Write("Array[{0}] : ", i);
    arr1[i] = Console.ReadLine();
}

string result = String.Join(", ", arr1
              .Select(s => s.ToString())
              .ToArray());

Console.WriteLine(result);
Console.Write("\n");
Console.ReadLine();