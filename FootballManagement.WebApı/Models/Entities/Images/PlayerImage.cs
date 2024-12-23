using FootballManagement.WebApi.Models.Dtos.Players.Image;

namespace FootballManagement.WebApi.Models.Entities.Images
{
    public class PlayerImage : Entity<Guid>
    {
        public Guid PlayerId { get; set; }

        public virtual Player Player { get; set; }

        public string Url { get; set; }

       
       
        public static implicit operator PlayerImage(PlayerImageAddRequestDto dto)
        {
            return new PlayerImage { PlayerId = dto.PlayerId };
        }
    }
}
