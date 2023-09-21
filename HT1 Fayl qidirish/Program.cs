class Program
{
    public static void Main()
    {
        var curDir = Environment.CurrentDirectory;
        var dirInfo = new DirectoryInfo(curDir);
        var files = dirInfo.GetFiles();
        foreach (var file in files)
        {
            var fileNameNoExt = Path.GetFileNameWithoutExtension(file.FullName);
            Console.WriteLine(String.Format("\"{0}\":\"{1}\"", file.FullName, fileNameNoExt));
        }
    }
}