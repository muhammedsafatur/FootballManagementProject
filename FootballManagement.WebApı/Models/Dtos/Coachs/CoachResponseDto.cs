using FootballManagement.WebApi.Models.Entities;

namespace FootballManagement.WebApi.Models.Dtos.Coachs;

public sealed record CoachResponseDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; } 
    public string Position { get; set; } 
    public string CountryName { get; set; }
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
