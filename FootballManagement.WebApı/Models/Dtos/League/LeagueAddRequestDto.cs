namespace FootballManagement.WebApi.Models.Dtos.League
{
    public class LeagueAddRequestDto
    {
        public string LeagueName { get; set; }
        public string FedaritonName { get; set; }

        public string LeagueLevel { get; set; }
        public int CountryId { get; set; }
        public bool IsActive { get; set; }
    }
}
