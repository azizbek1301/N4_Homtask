


using Newtonsoft.Json;
using (HttpClient client = new HttpClient())
{
    string BASE_URL = @"https://nbu.uz/uz/exchange-rates/json/";
    HttpResponseMessage responce = await client.GetAsync(BASE_URL);
    string respon = await responce.Content.ReadAsStringAsync();
    
    var data = JsonConvert.DeserializeObject<List<ValyutaAyriboshlash>>(respon);
    foreach(var val in data)
    {
       if(val.Code== "USD")
        {

            Console.WriteLine($"100000 so'm {100000/val.nbu_buy_price} $");
        }
    }
}






public class ValyutaAyriboshlash
{
    public string Title { get; set; }
    public string Code { get; set; }
    public double cb_price { get; set; }
    public double? nbu_buy_price { get; set; }
    public double? nbu_cell_price { get; set; }
    public DateTime? DateTime { get; set; }
}