namespace FootballManagement.WebApi.Models.Dtos.Coachs;

public sealed record CoachAddRequestDto(
    string FirstName,
    string LastName,
    string Position, // Pozisyon eklenmeli çünkü modelde var.
    int CountryId,
    int ClubId
);
