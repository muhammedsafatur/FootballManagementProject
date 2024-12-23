namespace FootballManagement.WebApi.Models.Dtos.ClubHistories
{
    public sealed record ClubHistoryAddRequestDto(
        int ClubId,
        DateTime StartDate,
        DateTime? EndDate,
        string Description
    );
}
