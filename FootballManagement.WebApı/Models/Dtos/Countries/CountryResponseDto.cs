using FootballManagement.WebApi.Models.Entities;

namespace FootballManagement.WebApi.Models.Dtos.Countries;

public sealed record CountryResponseDto(
    int Id,
    string Name,
    string IsoCode,
    string FlagUrl
)
{
    public static implicit operator CountryResponseDto(Country country)
    {
        return new CountryResponseDto(
            country.Id,
            country.Name,
            country.IsoCode,
            country.FlagUrl
        );
    }
}
