namespace FootballManagement.WebApi.Models.Entities.Images
{
    public class CountryImageAddRequestDto 
    {
        public int CountryId { get; init; }

        public IFormFile File { get; set; }
    }
}
