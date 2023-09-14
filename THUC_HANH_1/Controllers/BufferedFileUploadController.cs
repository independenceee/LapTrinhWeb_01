using Microsoft.AspNetCore.Mvc;
using THUC_HANH_1.services;
namespace THUC_HANH_1.Controllers
{
    
        public class BufferedFileUploadController : Controller
        {
            readonly IBufferedFileUploadLocalService _bufferedFileUploadService;

            public BufferedFileUploadController(IBufferedFileUploadLocalService bufferedFileUploadService)
            {
                _bufferedFileUploadService = bufferedFileUploadService;
            }

            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public async Task<ActionResult> Index(IFormFile file)
            {
                try
                {
                    if (await _bufferedFileUploadService.UploadFile(file))
                    {
                        ViewBag.Message = "File Upload Successful";
                    }
                    else
                    {
                        ViewBag.Message = "File Upload Failed";
                    }
                }
                catch
                {
                    //Log ex
                    ViewBag.Message = "File Upload Failed";
                }
                return View();
            }
        }
    
}
