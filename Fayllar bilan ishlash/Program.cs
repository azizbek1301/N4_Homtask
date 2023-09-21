
using System.Text;
using System.Xml;

//string path = "D:\\Dasturlash olami\\.Net Muhammad_Abdulloh_Projects\\Bootcamp_N7\\Fayllar bilan ishlash\\test.txt";
//string[] matn= new string[] { "Davomidan nimadur ","Yana nimadur","kitob" };

//await File.WriteAllLinesAsync(path, matn);
//Console.WriteLine("Ma'lumotlar yozilib bo'ldi");

//Console.WriteLine("---------------------------");

//bool mavjudmi = File.Exists(path);
//Console.WriteLine($"Fayl mavjudligi {mavjudmi}");


//string[] oqibOlish1=File.ReadAllLines(path);

//foreach (string line in oqibOlish1)
//{
//    Console.WriteLine(line);
//}



//string path = "D:\\Dasturlash olami\\.Net Muhammad_Abdulloh_Projects\\Bootcamp_N7\\Fayllar bilan ishlash\\test.txt";
//FileInfo fileInfo = new FileInfo(path);

//Console.WriteLine(fileInfo.OpenText().Read());



//string matn = "Bu fayl test uchun";
//Console.WriteLine(fileInfo.FullName);
//File.WriteAllText(fileInfo.FullName, matn);


//bool mavjudmi = fileInfo.Exists;
//Console.WriteLine($"Fayl mavjudligi {mavjudmi}");

//var oqibOlish = File.ReadAllText(path);
//Console.WriteLine($"Fayldagi matn {oqibOlish}");




// streamWriter && streamReader
// streamWriter step1


//var faylNom = "test.txt";
//string matn = "Bu faylga yozilgan matn";

//StreamWriter write=new StreamWriter(faylNom);
//write.Write(matn);
//write.Close();



// step2

//var faylNom = "test.txt";
//using(StreamWriter writer = new StreamWriter(faylNom))
//{
//    writer.WriteLine("Bu faylga yozilgan birinchi qator");
//    writer.WriteLine("bu esa ikkinchi qator");
//}


// StreamReader 

//var faylNomi = "test.txt";
//using(StreamReader reader = new StreamReader(faylNomi))
//{

//    Console.WriteLine(reader.ReadToEnd());
//    //string qator;
//    //while((qator = reader.ReadLine()) != null)

//    //{
//    //    Console.WriteLine(qator);
//    //}
//}



// MemoryStream

//using(MemoryStream memoryStream = new MemoryStream())
//{
//    var matn = "Bu memory stream orqali yozilgan matn";


//    byte[] matnBytes = Encoding.UTF8.GetBytes(matn);
//    memoryStream.Write(matnBytes, 0, matnBytes.Length);
//    memoryStream.Position = 0;

//    byte[] oqibOlishBytes=new byte[memoryStream.Length];
//    memoryStream.Read(oqibOlishBytes, 0, oqibOlishBytes.Length);

//    var oqibOlishMatn=Encoding.UTF8.GetString(oqibOlishBytes);
//    Console.WriteLine(oqibOlishMatn);
//}


string yangiPapka = @"C:\Test";
Directory.CreateDirectory(yangiPapka);

string[] fayllar = Directory.GetFiles(yangiPapka);
string[] direktoriyalar = Directory.GetDirectories(yangiPapka);

foreach (string fayl in fayllar)
{
    Console.WriteLine("Fayl: " + fayl);
}

foreach (string direktoriya in direktoriyalar)
{
    Console.WriteLine("Direktoriya: " + direktoriya);
}