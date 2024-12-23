using FootballManagement.WebApi.Models.Entities;

namespace FootballManagement.WebApi.Models.Dtos.Players
{
    public class PlayerResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int JerseyNumber { get; set; }
        public string Branch { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        // Club ve Country bilgileri eklendi
        public string ClubName { get; set; }
        public string CountryName { get; set; }

        // Parametreli constructor ekleyelim
        public PlayerResponseDto(Player player)
        {
            Id = player.Id;
            Name = player.Name;
            Surname = player.Surname;
            Age = player.Age;
            JerseyNumber = player.JerseyNumber;
            Branch = player.Branch.ToString(); // Enum to string
            Gender = player.Gender.ToString(); // Enum to string
            Salary = player.Salary;

            ClubName = player.Club?.Name ?? "Unknown"; // Eğer Club null ise "Unknown"
            CountryName = player.Country?.Name ?? "Unknown"; // Eğer Country null ise "Unknown"
        }
    }
}
