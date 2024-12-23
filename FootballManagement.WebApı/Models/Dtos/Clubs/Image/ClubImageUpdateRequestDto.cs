namespace FootballManagement.WebApi.Models.Dtos.Players.Image;

public sealed record ClubImageUpdateRequestDto
{
    public Guid Id { get; set; }

    public Guid ClubId { get; init; }
    public string Url { get; init; }
}
