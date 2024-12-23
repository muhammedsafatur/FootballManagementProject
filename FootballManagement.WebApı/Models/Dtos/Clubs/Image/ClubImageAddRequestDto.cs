namespace FootballManagement.WebApi.Models.Dtos.Images
{
    public class ClubImageAddRequestDto
    {
        public int ClubId { get; init; }

        public IFormFile File { get; set; }
    }
}
