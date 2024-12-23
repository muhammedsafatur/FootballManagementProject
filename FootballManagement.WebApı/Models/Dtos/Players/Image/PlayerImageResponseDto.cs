namespace FootballManagement.WebApi.Models.Dtos.Players.Image;

public sealed record PlayerImageResponseDto
{
    public Guid Id { get; init; }

    public Guid PlayerId { get; init; }

    public string PlayerName { get; init; }
    public string Url { get; init; }
}