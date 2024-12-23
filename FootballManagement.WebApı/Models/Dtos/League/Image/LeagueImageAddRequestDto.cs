using FootballManagement.WebApi.Models.Enums;

namespace FootballManagement.WebApi.Models.Dtos.Players.Image;

public sealed record LeagueImageAddRequestDto
{
    public int LeagueId { get; init; }

    public IFormFile File { get; set; }
}
