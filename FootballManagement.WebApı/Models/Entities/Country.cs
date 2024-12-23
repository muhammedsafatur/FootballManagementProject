﻿using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Models.Entities.Images;

namespace FootballManagement.WebApi.Models.Entities
{
    public class Country:Entity<int>
    {
        public string Name { get; set; }
        public string IsoCode { get; set; } // Ülke kodu (örn: "TR", "US")
        public string FlagUrl { get; set; } // Bayrak görseli

        // Relations
        public virtual List<Player> Players { get; set; }
        public virtual List<Coach> Coaches { get; set; }
        public virtual List<League> Leagues { get; set; }

        // Auditing
        public virtual List<CountryImage> CountryImages { get; set; }
        public Country()
        {
            Players = new List<Player>();
            Coaches = new List<Coach>();
            Leagues = new List<League>();
            CountryImages = new List<CountryImage>();
        }

    }
}
