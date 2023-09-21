

DateTime centuryBegin = new DateTime(2001, 1, 1);
DateTime currentDate=DateTime.Now;

long elapsedTicks=currentDate.Ticks-centuryBegin.Ticks;
TimeSpan elapsedSapan=new TimeSpan(elapsedTicks);

Console.WriteLine("Elapsed from the beginning of the century to {0:f}:",currentDate);
Console.WriteLine(" ")