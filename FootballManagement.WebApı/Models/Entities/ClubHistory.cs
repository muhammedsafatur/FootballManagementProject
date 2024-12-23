using FootballManagement.WebApi.Models.Entities;

namespace FootballManagement.WebApi.Models.Entities
{
    public class ClubHistory : Entity<int>
    {

        public Guid PlayerId { get; set; }
        public Guid CoachId { get; set; }
        public int ClubId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }
        public virtual Club Club { get; set; }





    }
}
