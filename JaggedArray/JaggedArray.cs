namespace JaggedArray
{
    public static class JaggedArray
    {
        
        public static  int[][] AddElement(this int [][] jagArr,int index,int element)
        {
            List<int> result = jagArr[index].ToList<int>();
            var yordamchi=result.Append(element);
            jagArr[index]=yordamchi.ToArray();
            return jagArr;
        }
    }
}
