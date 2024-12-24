using FootballManagement.WebApi.Models.Dtos.Players;
using FootballManagement.WebApi.Models.Entities;

namespace FootballManagement.WebApi.Models.Dtos.Clubs
{
    public sealed record ClubResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string YearOfEstablishment { get; set; }

        // Opsiyonel alanlar
        public string? CountryName { get; set; }
        public string? LeagueName { get; set; }
        public string? LogoUrl { get; set; }
        public List<PlayerResponseDto> Players { get; set; } = new List<PlayerResponseDto>();

        public static implicit operator ClubResponseDto(Club club)
        {
            return new ClubResponseDto
            {
                Id = club.Id,
                Name = club.Name,
                YearOfEstablishment = club.YearOfEstablishment,
                LeagueName = club.Leagues?.LeagueName,  // Eğer bir lig varsa, adını al
                LogoUrl = club.LogoUrl,  // Eğer kulüp logosu varsa
                Players = club.Players?.Select(p => new PlayerResponseDto(p)).ToList()  // Kulüp oyuncuları DTO'su şeklinde
            };
        }
    }
}
