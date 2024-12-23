using FootballManagement.WebApi.Models.Enums;

namespace FootballManagement.WebApi.Models.Dtos.PlayerImages;

public sealed record PlayerImageAddRequestDto
{
    public Guid PlayerId { get; init; }

    public IFormFile File { get; set; }
}
