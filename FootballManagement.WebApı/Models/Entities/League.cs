using FootballManagement.WebApi.Models.Entities;
using static System.Reflection.Metadata.BlobBuilder;

namespace FootballManagement.WebApi.Models.Entities
{
    public class League:Entity<int>
    {
        public string LeagueName { get; set; }
        public string FedaritonName { get; set; }

        public string LeagueLevel { get; set; } 
        public bool IsActive { get; set; }

        public virtual List<Player> players { get; set; }
        public virtual List<Club> clubs { get; set; }
        public virtual List<Coach> coachs { get; set; }
        public League()
        {
            players = new List<Player>();
            clubs = new List<Club>();
            coachs = new List<Coach>();
        }
    }
}
