using FootballManagement.WebApi.Models.Entities.Images;
using FootballManagement.WebApi.Models.Enums;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace FootballManagement.WebApi.Models.Entities
{
    public class Player:Entity<Guid>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public int JerseyNumber { get; set; }
        public Branch Branch { get; set; }

        public Gender Gender { get; set; }

        public decimal Salary { get; set; }


        public int ClubId { get; set; }
        public virtual Club Club { get; set; }



        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual List<PlayerImage> PlayerImages { get; set; }
        public Player()
        {

            PlayerImages = new List<PlayerImage>();
        }
    }
}
