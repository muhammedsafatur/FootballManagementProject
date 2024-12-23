using FootballManagement.WebApi.Models.Enums;

namespace FootballManagement.WebApi.Models.Dtos.Players
{
    public sealed record PlayerUpdateRequestDto
    {
        public Guid Id { get; set; } // Güncelleme yapılacak oyuncunun Id'si

        public string Name { get; set; } // Oyuncunun adı

        public string Surname { get; set; } // Oyuncunun soyadı

        public int Age { get; set; } // Oyuncunun yaşı

        public int JerseyNumber { get; set; } // Oyuncunun forma numarası

        public Branch Branch { get; set; } // Oyuncunun branşı (örneğin Futbol, Basketbol vb.)

        public Gender Gender { get; set; } // Oyuncunun cinsiyeti

        public decimal Salary { get; set; } // Oyuncunun maaşı

        public int ClubId { get; set; } // Oyuncunun kulübü

        public int CountryId { get; set; } // Oyuncunun bağlı olduğu ülke
    }
}
