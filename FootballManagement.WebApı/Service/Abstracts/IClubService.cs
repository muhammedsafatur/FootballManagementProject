using FootballManagement.WebApi.Models.Dtos.Clubs;
using FootballManagement.WebApi.Utils.ReturnModels;


namespace FootballManagement.WebApi.Service.Abstracts;

public interface IClubService
{
    ReturnModel<List<ClubResponseDto>> GetAllClubs();
    ReturnModel<ClubResponseDto> GetById(int id);
    ReturnModel<NoData> Add(ClubAddRequestDto addRequestDto);
    ReturnModel<NoData> Update(ClubUpdateRequestDto updateRequestDto);

    ReturnModel<NoData> Delete(int id);
}
