﻿namespace FootballManagement.WebApi.Models.Entities.Images
{
    public class CoachImageAddRequestDto 
    {
        public Guid CoachId { get; init; }

        public IFormFile File { get; set; }
    }
}
