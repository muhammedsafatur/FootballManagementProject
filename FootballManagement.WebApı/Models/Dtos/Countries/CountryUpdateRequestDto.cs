namespace FootballManagement.WebApi.Models.Dtos.Countries;

public sealed record CountryUpdateRequestDto(int Id, string Name, string IsoCode, string FlagUrl);
