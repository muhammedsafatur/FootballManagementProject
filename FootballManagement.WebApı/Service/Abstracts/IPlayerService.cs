using FootballManagement.WebApi.Models.Dtos.Players;
using FootballManagement.WebApi.Utils.ReturnModels;

namespace FootballManagement.WebApi.Service.Abstracts;

public interface IPlayerService
{
    ReturnModel<List<PlayerResponseDto>> GetAll();
    ReturnModel<PlayerResponseDto> GetById(Guid id);
    ReturnModel<NoData> Add(PlayerAddRequestDto addRequestDto);
    ReturnModel<NoData> Update(PlayerUpdateRequestDto updateRequestDto);

    ReturnModel<NoData> Delete(Guid id);


    ReturnModel<List<PlayerDetailResponseDto>> GetAllPlayerDetails();
    ReturnModel<PlayerDetailResponseDto> GetPlayerDetailById(Guid id);
}

