using AutoMapper;
using FootballManagement.WebApi.Utils.ReturnModels;
using FootballManagement.WebApi.Repository.Abstracts.IImages;
using FootballManagement.WebApi.Service.Helpers.CloudinaryHelper;
using FootballManagement.WebApi.Models.Dtos.Players.Image;
using FootballManagement.WebApi.Models.Entities.Images;
using FootballManagement.WebApi.Service.Abstracts;

namespace FootballManagement.WebApi.Services.Concretes;

public sealed class PlayerImageService(IPlayerImageRepository _playerImageRepository,
    IMapper _mapper,
    ICloudinaryService _cloudinaryService
    
    ) : IPlayerImageService
{



    public ReturnModel<NoData> Add(PlayerImageAddRequestDto addRequestDto)
    {
        PlayerImage image = addRequestDto;

        var url = _cloudinaryService.UploadImage(addRequestDto.File,"players");

        image.Url = url;

        _playerImageRepository.Add(image);

        return new ReturnModel<NoData> { Message = "Resim yüklendi.", Success = true };

    }

    public ReturnModel<List<PlayerImageResponseDto>> GetAll()
    {
        var images = _playerImageRepository.GetAll();

        var response = _mapper.Map<List<PlayerImageResponseDto>>(images);

        return new ReturnModel<List<PlayerImageResponseDto>> { Data = response, Success = true };
    }

    public ReturnModel<List<PlayerImageResponseDto>> GetAllByPlayerId(Guid id)
    {
        var images = _playerImageRepository.GetAll(x=>x.PlayerId==id);

        var response = _mapper.Map<List<PlayerImageResponseDto>>(images);

        return new ReturnModel<List<PlayerImageResponseDto>> { Data = response, Success = true };
    }

    public ReturnModel<PlayerImageResponseDto> GetById(Guid id)
    {
        var image = _playerImageRepository.Get(x=>x.Id==id);
        
        var response = _mapper.Map<PlayerImageResponseDto>(image);

        return new ReturnModel<PlayerImageResponseDto> { Data = response, Success = true };
    }
}
