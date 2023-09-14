namespace THUC_HANH_1.services
{
    public interface IBufferedFileUploadLocalService
    {
        Task<bool> UploadFile(IFormFile file);
    }
}
