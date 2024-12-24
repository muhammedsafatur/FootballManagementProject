using FootballManagement.WebApi.Models.Dtos.Countries;
using FootballManagement.WebApi.Utils.ReturnModels;

namespace FootballManagement.WebApi.Service.Abstracts;

public interface ICountryService
{
    ReturnModel<List<CountryResponseDto>> GetAll();
    ReturnModel<CountryResponseDto> GetById(int id);
    ReturnModel<NoData> Add(CountryAddRequestDto addRequestDto);
    ReturnModel<NoData> Update(CountryUpdateRequestDto updateRequestDto);

    ReturnModel<NoData> Delete(int id);
}
