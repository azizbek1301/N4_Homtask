using FilmSearchBot.Models;
using Newtonsoft.Json;

namespace FilmSearchBot
{
    public class ApiBroker
    {
        public static async Task<ListOfSearch> GetFilmListAsync(string name, int pageNumber = 1)
        {
            if (pageNumber <= 1)
                pageNumber = 1;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.omdbapi.com/");
            var json = await client.GetStringAsync($"?apikey=8590bdaf&s={name}&page={pageNumber}");
            var root = JsonConvert.DeserializeObject<ListOfSearch>(json);

            root.PageNumber = pageNumber;

            if (pageNumber <= 1)
                root.PageNumber = 1;

            root.SearchKey = name;

            return root;
        }

        public static async Task<Film> GetFilmAsync(string imdbID)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.omdbapi.com/");
            var json = await client.GetStringAsync($"?apikey=8590bdaf&i={imdbID}");
            var film = JsonConvert.DeserializeObject<Film>(json);
            return film;
        }
    }
}