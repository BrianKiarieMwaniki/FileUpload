using FileUpload.Services.FileServices;
using FileUpload.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IFileUploadService _fileUploadService;
        private readonly IHttpContextAccessor _accessor;
        public string filePath;

        [BindProperty]
        public IFormFile File { get; set; }

        public IndexModel(IFileUploadService fileUploadService, IHttpContextAccessor accessor)
        {
            _fileUploadService = fileUploadService;
            _accessor = accessor;
        }

        public void OnGet()
        {

        }

        public async Task OnPost()
        {
            if (File is null) return;

           var imagePath = await _fileUploadService.UploadFileAsync(File);

            filePath = $"{BaseUrlHelper.GetAppBasePathUrl((HttpContextAccessor)_accessor)}/uploads/images/{File.FileName}";
        }
    }
}
