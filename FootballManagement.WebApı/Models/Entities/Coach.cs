﻿using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Models.Entities.Images;

namespace FootballManagement.WebApi.Models.Entities
{
    public class Coach:Entity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Position { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public List<ClubHistory> ClubHistories { get; set; }

        public int ClubId { get; set; }
        public Club Club { get; set; }
        public string FullName=> $"{FirstName} {LastName}";

        public virtual List<CoachImage> CoachImages { get; set; }
        public Coach()
        {

            CoachImages = new List<CoachImage>();
        }
    }
}
