using FootballManagement.WebApi.Models.Dtos.Clubs;
using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Repository.Abstracts;
using FootballManagement.WebApi.Service.Abstracts;
using FootballManagement.WebApi.Utils.ReturnModels;

namespace FootballManagement.WebApi.Service.Concretes;

public class ClubService(IClubRepository _clubRepository) : IClubService
{
    public ReturnModel<NoData> Add(ClubAddRequestDto addRequestDto)
    {
        Club club = addRequestDto;
        _clubRepository.Add(club);

        return new ReturnModel<NoData> { Message = "Takım Eklendi", Success = true };
    }

    public ReturnModel<NoData> Delete(int id)
    {
        if (!ClubIsPresent(id))
        {
            return new ReturnModel<NoData> { Message = $"Takım bulunamadı Id:{id}", Success = false };
        }


        var club = _clubRepository.Get(x => x.Id == id);

        _clubRepository.Remove(club);

        return new ReturnModel<NoData> { Message = "Takım Silindi.", Success = true };

    }

    public ReturnModel<List<ClubResponseDto>> GetAllClubs()
    {
        List<Club> clubs = _clubRepository.GetAll(enableTracking: false, include: false);
        List<ClubResponseDto> responses = clubs.Select(x => (ClubResponseDto)x).ToList();
        return new ReturnModel<List<ClubResponseDto>> { Data = responses, Success = true };
    }

    public ReturnModel<ClubResponseDto> GetById(int id)
    {
        if (!ClubIsPresent(id))
        {
            return new ReturnModel<ClubResponseDto> { Message = $"Takım bulunamadı Id:{id}", Success = false };
        }

        var club = _clubRepository.Get(predicate: x => x.Id == id, enableTracking: true, include: false);

        ClubResponseDto responseDto = club!;


        return new ReturnModel<ClubResponseDto> { Data = responseDto, Success = true };

    }

    public ReturnModel<NoData> Update(ClubUpdateRequestDto updateRequestDto)
    {
        if (!ClubIsPresent(updateRequestDto.Id))
        {
            return new ReturnModel<NoData> { Message = $"Takım bulunamadı Id:{updateRequestDto.Id}", Success = false };
        }

        Club club = updateRequestDto;

        _clubRepository.Update(club);

        return new ReturnModel<NoData> { Message = "Takım Güncellendi.", Success = true };
    }


    // private metods ,

    private bool ClubIsPresent(int id)
    {
        return _clubRepository.Any(predicate: x => x.Id == id);
    }


}
