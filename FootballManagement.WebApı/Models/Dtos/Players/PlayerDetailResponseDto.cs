using FootballManagement.WebApi.Models.Enums;

namespace FootballManagement.WebApi.Models.Dtos.Players;

public class PlayerDetailResponseDto
{
    public Guid Id { get; set; }

    public string Name { get; init; }

    public string Surname { get; init; }

    public int Age { get; init; }

    public int JerseyNumber { get; init; }
    public Branch Branch { get; init; }

    public Gender Gender { get; init; }

    public decimal Salary { get; init; }


    public string ClubName { get; init; }

    public string CountryName { get; init; }

    public List<string> Images { get; init; }
}
