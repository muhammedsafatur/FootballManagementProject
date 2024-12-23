using FootballManagement.WebApi.Models.Entities;

namespace FootballManagement.WebApi.Models.Dtos.Countries;

public sealed record CountryAddRequestDto(string Name, string IsoCode, string FlagUrl)
{
    public static implicit operator Country(CountryAddRequestDto dto)
    {
        return new Country
        {
            Name = dto.Name,
            IsoCode = dto.IsoCode,
            FlagUrl = dto.FlagUrl // Eğer dosya destekliyorsanız bu alanı güncelleyin.
        };
    }
}
