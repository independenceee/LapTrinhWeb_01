namespace THUC_HANH_1.Services;

public interface IBufferedFileUploadService
{
    Task<bool> UploadFile(IFormFile file);
}
