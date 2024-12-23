namespace FootballManagement.WebApi.Models.Dtos.ClubHistories
{
    public sealed record ClubHistoryUpdateRequestDto(
        int Id,                     // Güncellenmek istenen ClubHistory'nin ID'si
        int ClubId,                 // Güncellenmiş Club ID'si
        string StartDate,           // Yeni başlangıç tarihi
        string? EndDate,            // Yeni bitiş tarihi (nullable)
        string Description,         // Yeni açıklama
        Guid CoachId,               // Yeni antrenör ID'si
        Guid PlayerId               // Yeni oyuncu ID'si
    );
}
