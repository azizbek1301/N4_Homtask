namespace FilmSearchBot.Models
{
    public class ListOfSearch
    {
        public List<Search> Search { get; set; }
        public string totalResults { get; set; }
        public string Response { get; set; }
        public int? PageNumber { get; set; }
        public string? SearchKey { get; set; }
    }
}
