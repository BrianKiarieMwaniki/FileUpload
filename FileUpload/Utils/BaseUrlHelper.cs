using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Utils
{
    public static class BaseUrlHelper
    {
        public static string GetAppBasePathUrl(HttpContextAccessor accessor)
        {
            string scheme = accessor.HttpContext.Request.Scheme;
            string host = accessor.HttpContext.Request.Host.Value;
            string pathBase = accessor.HttpContext.Request.PathBase.Value;
            return $"{scheme}://{host}{pathBase}";
        }
    }
}
