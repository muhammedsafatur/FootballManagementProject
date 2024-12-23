﻿using FootballManagement.WebApi.Models.Dtos.Clubs;
using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Models.Entities.Images;

namespace FootballManagement.WebApi.Models.Entities
{
    public class Club:Entity<int>
    {
        public string Name { get; set; }

        public string YearOfEstablishment { get; set; }

        public string? LogoUrl { get; set; }

        public int LeagueId { get; set; }
        public League League { get; set; }

        public List<Player> Players { get; set; }




        public static implicit operator Club(ClubAddRequestDto dto)
        {
            return new Club
            {
                Name = dto.Name,
                LogoUrl = dto.LogoUrl,
                YearOfEstablishment=dto.YearOfEstablishment
            };
        }


        public static implicit operator Club(ClubUpdateRequestDto dto)
        {
            return new Club
            {
                Id = dto.Id,
                Name = dto.Name,
                YearOfEstablishment = dto.YearOfEstablishment,
                LeagueId= dto.LeagueId
            };
        }
    }
}
