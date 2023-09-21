namespace JaggedArray
{
    public static class JaggedArray
    {
        
        public static  int[][] AddElement(this int[][] jagArr,int index,int element)
        {
            List<int> result = jagArr[index].ToList<int>();
            var yordamchi=result.Append(element);
            jagArr[index]=yordamchi.ToArray();
            return jagArr;
        }
        public static int[][] AddElement(this int[][] array, int element)
        {
            var Arrray = new int[array.Length + 1][];
            int j = 0;
            foreach (var i in array)
            {
                var item = i.ToList();
                Arrray[j] = item.ToArray();
                j++;
            }
            Arrray[j] = new int[] { element };
            return Arrray;

        }
    }
}
