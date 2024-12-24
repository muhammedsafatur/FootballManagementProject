using FootballManagement.WebApi.Models.Dtos.Coachs;
using FootballManagement.WebApi.Utils.ReturnModels;

namespace FootballManagement.WebApi.Service.Abstracts;

public interface ICoachService
{
    ReturnModel<List<CoachResponseDto>> GetAll();
    ReturnModel<CoachResponseDto> GetById(Guid id);
    ReturnModel<NoData> Add(CoachAddRequestDto addRequestDto);
    ReturnModel<NoData> Update(CoachUpdateRequestDto updateRequestDto);

    ReturnModel<NoData> Delete(Guid id);
}