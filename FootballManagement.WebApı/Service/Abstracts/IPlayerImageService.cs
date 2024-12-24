using FootballManagement.WebApi.Models.Dtos.Players.Image;
using FootballManagement.WebApi.Utils.ReturnModels;

namespace FootballManagement.WebApi.Service.Abstracts;

public interface IPlayerImageService
{
    ReturnModel<List<PlayerImageResponseDto>> GetAll();
    ReturnModel<PlayerImageResponseDto> GetById(Guid id);
    ReturnModel<NoData> Add(PlayerImageAddRequestDto addRequestDto);

    ReturnModel<List<PlayerImageResponseDto>> GetAllByPlayerId(Guid id);
}

