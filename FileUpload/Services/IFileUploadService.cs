using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace FileUpload.Services
{
    public interface IFileUploadService
    {
        Task<string> UploadFileAsync(IFormFile file);
    }
}