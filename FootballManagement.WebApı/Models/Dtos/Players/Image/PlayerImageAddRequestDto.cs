
namespace FootballManagement.WebApi.Models.Dtos.Players.Image;

public sealed record PlayerImageAddRequestDto
{
    public Guid PlayerId { get; init; }

    public IFormFile File { get; set; }
}
