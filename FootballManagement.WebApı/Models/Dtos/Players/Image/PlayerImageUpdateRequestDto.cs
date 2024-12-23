namespace FootballManagement.WebApi.Models.Dtos.Players.Image;

public sealed record PlayerImageUpdateRequestDto
{
    public Guid Id { get; set; }

    public Guid PlayerId { get; init; }
    public string Url { get; init; }
}
