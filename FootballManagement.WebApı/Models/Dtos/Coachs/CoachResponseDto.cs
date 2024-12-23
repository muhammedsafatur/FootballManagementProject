using FootballManagement.WebApi.Models.Entities;

namespace FootballManagement.WebApi.Models.Dtos.Coachs;

public sealed record CoachResponseDto
{
    public Guid Id { get; init; }
    public string FullName { get; init; } // Modeldeki FullName'i kullanın.
    public string Position { get; init; } // Pozisyon bilgisi eklendi.
    public string CountryName { get; init; }
    public string ClubName { get; set; }

    public static implicit operator CoachResponseDto(Coach coach)
    {
        return new CoachResponseDto
        {
            Id = coach.Id,
            FullName = coach.FullName,
            Position = coach.Position,
            CountryName = coach.Country?.Name ?? "Unknown",
            ClubName = coach.Club?.Name ?? "Free Agent"
        };
    }

}
