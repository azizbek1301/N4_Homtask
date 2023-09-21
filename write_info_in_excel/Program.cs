using OfficeOpenXml;
internal class Program
{
    private static void Main(string[] args)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Sinov.xlsx");
        using (var package = new ExcelPackage(path))
        {
            #region Bu yerda faqatgina file bor yo'qligi
            FileInfo file = new FileInfo(path);
            if (!file.Exists)
            {
                File.Create(path).Close();
            }
            #endregion
            var sheet = package.Workbook.Worksheets["My Sheets"];
            sheet.Cells[$"A1"].Value = "#T/R";
            sheet.Cells[$"B1"].Value = "Ism-familiya";
            sheet.Cells[$"C1"].Value = "Tel number";
            sheet.Cells[$"D1"].Value = "Age";
            int tartib = 0;
            bool tekshir = true;
            while (tekshir)
            {
                int age;
                string ism, telNumber;
                Console.WriteLine("Ism- Familiyangizni kiriting");
                ism = Console.ReadLine();
                Console.WriteLine("Telefon raqamingizni kiriting");
                telNumber = Console.ReadLine();
                Console.WriteLine("Yoshingizni kiriting");
                age = int.Parse(Console.ReadLine());
                sheet.Cells[$"A{tartib + 2}"].Value = tartib + 1;
                sheet.Cells[$"B{tartib + 2}"].Value = ism;
                sheet.Cells[$"c{tartib + 2}"].Value = telNumber;
                sheet.Cells[$"D{tartib + 2}"].Value = age;
                tartib += 1;
                Console.WriteLine("Yana ma'lumot qo'shasizmi(ha/yoq)");
                var javob = Console.ReadLine();
                if (javob.ToLower() != "ha")
                {
                    tekshir = false;

                }

            }
            package.Save();
        }
        
    }
}




