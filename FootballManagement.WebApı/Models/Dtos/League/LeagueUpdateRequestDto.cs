namespace FootballManagement.WebApi.Models.Dtos.League
{
    public class LeagueUpdateRequestDto
    {
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public string FedaritonName { get; set; }

        public string LeagueLevel { get; set; }
        public bool IsActive { get; set; }
    }
}
