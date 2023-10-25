string[] dirfiles = Directory.GetFiles("\\Dasturlash olami\\homtasks\\homtasks\\calculator");
var avgFsize = dirfiles.Select(file => new FileInfo(file).Length).Average();
avgFsize = Math.Round(avgFsize / 10, 1);
Console.WriteLine("The Average file size is {0} MB", avgFsize);