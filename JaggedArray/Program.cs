
using JaggedArray;

int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[] { 1,2,3 };
jaggedArray[1] = new int[] { 1,2,2};

jaggedArray.AddElement(1,5);


for(var i=0;i<jaggedArray.Length;i++)
{
    for(var j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("----------------------------------");
jaggedArray.AddElement(3);
for (var i = 0; i < jaggedArray.Length; i++)
{
    for (var j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}

