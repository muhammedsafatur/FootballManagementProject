using FootballManagement.WebApi.Models.Entities;

namespace FootballManagement.WebApi.Models.Dtos.ClubHistories
{
    public sealed record ClubHistoryResponseDto(
        int Id,
        int ClubId,
        string ClubName,
        string StartDate,
        string? EndDate,
        string Description,
        Guid CoachId,
        Guid PlayerId
    )
    {
        public static implicit operator ClubHistoryResponseDto(ClubHistory history)
        {
            return new ClubHistoryResponseDto(
                history.Id,
                history.ClubId,
                history.Club?.Name ?? "Unknown", // ClubName'i Club'dan alıyoruz.
                history.StartDate,
                history.EndDate,
                history.Description,
                history.CoachId,
                history.PlayerId
            );
        }
    }
}
