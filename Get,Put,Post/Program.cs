

using Newtonsoft.Json;
using System.Text;

var json = JsonConvert.SerializeObject("N777");
var data = new StringContent(json, Encoding.UTF8, "application/json");

var url = @"https://7153/api/Products/Categories";
using var client = new HttpClient();

var response = await client.PostAsync(url, data);

var result = await response.Content.ReadAsStringAsync();
Console.WriteLine(result);