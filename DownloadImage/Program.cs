 /*using (HttpClient client = new HttpClient())
          {
              var link = Console.ReadLine();

              byte[] image = await client.GetByteArrayAsync(link);

              var filename = Guid.NewGuid().ToString()+".png";

              string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),filename);

              File.WriteAllBytes(path, image);

              Console.WriteLine(Path.Combine(path, filename));
          }
 */
using System.Net;

Console.WriteLine("Rasmning linkini kiriting:");
string link = Console.ReadLine();

using (WebClient client = new WebClient())
{
    try
    {
        string fileName = "image.jpg"; // Rasm fayl nomi
        client.DownloadFile(link, fileName);
        string path = System.IO.Path.GetFullPath(fileName);
        Console.WriteLine("Rasm muvaffaqiyatli yuklandi. Yo'l: " + path);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Rasmni yuklashda xatolik yuz berdi: " + ex.Message);
    }
}