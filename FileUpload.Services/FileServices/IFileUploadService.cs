using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace FileUpload.Services.FileServices
{
    public interface IFileUploadService
    {
        Task<string> UploadFileAsync(IFormFile file);
    }
}