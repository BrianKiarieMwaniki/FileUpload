using FileUpload.Services;
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

        public string filePath;

        [BindProperty]
        public IFormFile File { get; set; }

        public IndexModel(IFileUploadService fileUploadService)
        {
            _fileUploadService = fileUploadService;
        }

        public void OnGet()
        {

        }

        public async Task OnPost()
        {
            if (File is null) return;

            filePath = await _fileUploadService.UploadFileAsync(File);
        }
    }
}
