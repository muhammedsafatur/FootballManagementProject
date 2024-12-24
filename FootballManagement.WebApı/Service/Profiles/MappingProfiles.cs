using AutoMapper;
using FootballManagement.WebApi.Models.Dtos.Coachs;
using FootballManagement.WebApi.Models.Dtos.Countries;

using FootballManagement.WebApi.Models.Dtos.Players;
using FootballManagement.WebApi.Models.Dtos.Players.Image;
using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Models.Entities.Images;

namespace FootballManagement.WebApi.Service.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // Coach Profiles

        CreateMap<CoachAddRequestDto, Coach>();
        CreateMap<CoachUpdateRequestDto, Coach>();
        CreateMap<Coach, CoachResponseDto>().ReverseMap();


        // Country Profiles
        CreateMap<Country, CountryResponseDto>();
        CreateMap<CountryAddRequestDto, Country>();
        CreateMap<CountryUpdateRequestDto, Country>();


        //Player Profiles
        CreateMap<Player, PlayerResponseDto>();
        CreateMap<PlayerAddRequestDto, Player>();
        CreateMap<PlayerUpdateRequestDto, Player>();
        CreateMap<Player, PlayerDetailResponseDto>()
            .ForMember(x => x.Images, opt => opt.MapFrom(x => x.PlayerImages.Select(p => p.Url).ToList()));



        CreateMap<PlayerImageAddRequestDto, Player>();
        CreateMap<PlayerImage, PlayerImageResponseDto>();
        CreateMap<PlayerImageUpdateRequestDto, PlayerImage>();





    }
}
