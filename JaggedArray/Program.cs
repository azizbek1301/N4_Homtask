
int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[] { 1,2,3 };
jaggedArray[1] = new int[] { 1,2,2};

jaggedArray = JagArray.AddElement(jaggedArray,1, 7);


for(var i=0;i<jaggedArray.Length;i++)
{
    for(var j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("----------------------------------");
jaggedArray = JagArray.AddElement(jaggedArray, 10);
for (var i = 0; i < jaggedArray.Length; i++)
{
    for (var j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
public class JagArray
{
    

    public static int[][] AddElement(int[][] array,int index, int element)
    {
        List<int> ArrayTolist = array[index].ToList<int>();
        var d = ArrayTolist.Append(element);
        array[index] = d.ToArray();
        return array;
    }


   public static int[][] AddElement(int[][] array,  int element)
    {
        var Arrray = new int[array.Length + 1][];
        int j = 0;
        foreach(var i in array)
        {
            var item = i.ToList();
            Arrray[j]=item.ToArray();
            j++;
        }
        Arrray[j] = new int[] { element };
        return Arrray;

    }
}
