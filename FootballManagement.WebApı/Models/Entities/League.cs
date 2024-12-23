using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Models.Entities.Images;
using static System.Reflection.Metadata.BlobBuilder;

namespace FootballManagement.WebApi.Models.Entities
{
    public class League:Entity<int>
    {
        public string LeagueName { get; set; }
        public string FedaritonName { get; set; }

        public string LeagueLevel { get; set; } 
        public bool IsActive { get; set; }

        public virtual List<Player> Players { get; set; }
        public virtual List<Club> Clubs { get; set; }
        public virtual List<Coach> Coachs { get; set; }
        public virtual Country Country { get; set; }
        public League()
        {
            Players = new List<Player>();
            Clubs = new List<Club>();
            Coachs = new List<Coach>();
            LeagueImages = new List<LeagueImage>();
            Country= new Country();



        }
        public virtual List<LeagueImage> LeagueImages { get; set; }

    }
}
