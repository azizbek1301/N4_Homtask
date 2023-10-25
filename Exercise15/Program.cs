

string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

var result=arr1.Select(x=>Path.GetExtension(x).TrimStart('.').ToLower())
                        .GroupBy(z => z, (kengaytma, soni) => new
                        {
                            Fayl=kengaytma,
                            Miqdori=soni.Count()
                        });
foreach (var item in result)
{
    Console.WriteLine($"{item.Miqdori} ta {item.Fayl} kengaytma");
}