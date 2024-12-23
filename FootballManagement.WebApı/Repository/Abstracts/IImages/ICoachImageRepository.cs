﻿using FootballManagement.WebApi.Models.Entities.Images;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;

namespace FootballManagement.WebApi.Repository.Abstracts.IImages
{
    public interface ICoachImageRepository : IRepository<CoachImage, Guid>
    {
    }
}
