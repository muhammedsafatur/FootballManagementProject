namespace FootballManagement.WebApi.Models.Dtos.Coachs;

public sealed record CoachUpdateRequestDto(
    Guid Id,
    string FirstName,
    string LastName,
    string Position,
    int CountryId,
    int ClubId
);
