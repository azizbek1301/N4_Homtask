


class Program
{
    static async Task Main()
    {
        using(HttpClient client = new HttpClient())
        {
            try
            {
                // Get so'rovini yuborish
                HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
                // Javobni o'qish

                var responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);

            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}