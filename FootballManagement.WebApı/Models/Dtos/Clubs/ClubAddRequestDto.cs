namespace FootballManagement.WebApi.Models.Dtos.Clubs
{
    public sealed record ClubAddRequestDto
    {
        public string Name { get; init; }
        public string YearOfEstablishment { get; init; }

        // Eğer gelecekte bir ülke eklemek istiyorsanız, CountryId ekleyebilirsiniz.
        public int? CountryId { get; init; }  // Opsiyonel alan

        // Eğer kulübün logosu veya resminin URL'si gibi bir şey ekleyecekseniz, ClubImageId ya da URL ekleyebilirsiniz.
        public string? LogoUrl { get; init; }  // Opsiyonel logo URL'si

        // Eğer başka bir ilişki (örneğin, lig) olacaksa, bunu buraya ekleyebilirsiniz.
        public int? LeagueId { get; init; }  // Opsiyonel lig ID'si
    }
}
