namespace FootballManagement.WebApi.Service.Helpers.CloudinaryHelper;

public interface ICloudinaryService
{
    string UploadImage(IFormFile formFile, string directoryName);
}
