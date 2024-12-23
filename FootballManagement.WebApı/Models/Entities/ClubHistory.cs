using FootballManagement.WebApi.Models.Entities;

namespace FootballManagement.WebApi.Models.Entities
{
    public class ClubHistory:Entity<int>
    {
       
            public Guid PlayerId { get; set; }
            public Guid CoachId { get; set; }
            public int ClubId { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
        

    }
}
