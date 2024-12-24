namespace FootballManagement.WebApi.Models.Dtos.League
{
    public class LeagueDetailResponseDto
    {
        public int LeagueId { get; init; }
        public string LeagueName { get; init; }
        public string FedaritonName { get; init; }

        public string LeagueLevel { get; init; }
        public bool IsActive { get; init; }
        public List<string> Images { get; init; }
    }
}
