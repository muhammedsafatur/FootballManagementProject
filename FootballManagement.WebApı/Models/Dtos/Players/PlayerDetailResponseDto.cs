using FootballManagement.WebApi.Models.Enums;

namespace FootballManagement.WebApi.Models.Dtos.Players
{
    public class PlayerDetailResponseDto
    {
        public Guid Id { get; set; }  // Oyuncunun ID'si

        public string Name { get; init; }  // Oyuncunun adı

        public string Surname { get; init; }  // Oyuncunun soyadı

        public int Age { get; init; }  // Oyuncunun yaşı

        public int JerseyNumber { get; init; }  // Oyuncunun forma numarası

        public Branch Branch { get; init; }  // Oyuncunun branşı (Futbol, Basketbol vb.)

        public Gender Gender { get; init; }  // Oyuncunun cinsiyeti

        public decimal Salary { get; init; }  // Oyuncunun maaşı

        public string ClubName { get; init; }  // Oyuncunun kulübünün adı

        public string CountryName { get; init; }  // Oyuncunun ülkesinin adı

        public List<string> Images { get; init; }  // Oyuncuya ait resimlerin URL'leri
    }
}
