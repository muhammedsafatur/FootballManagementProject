namespace FootballManagement.WebApi.Models.Dtos.Players.Image;

public sealed record ClubImageResponseDto
{
    public Guid Id { get; init; }

    public int ClubId { get; init; }

    public string ClubName { get; init; }
    public string Url { get; init; }
}