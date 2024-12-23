namespace FootballManagement.WebApi.Models.Dtos.Clubs;

public sealed record ClubUpdateRequestDto(int Id, string Name, string YearOfEstablishment,int LeagueId);
