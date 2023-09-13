namespace THUC_HANH_1.Controllers.Interfaces
{
    public interface IUploadFile
    {
        Task<bool> Upload(IFormFile file);
    }
}
