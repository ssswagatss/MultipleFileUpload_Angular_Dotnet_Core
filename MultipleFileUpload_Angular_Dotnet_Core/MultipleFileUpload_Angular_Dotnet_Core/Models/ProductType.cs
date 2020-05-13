using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleFileUpload_Angular_Dotnet_Core.Models
{
    public class ProductTypeDTO
    {
        public string Description { get; set; }
        public string Volume { get; set; }
        public IEnumerable<AdritaFile> ProductImages { get; set; }
        public AdritaFile SingleImage { get; set; }
    }

    public class AdritaFile
    {
        public IFormFile File { get; set; }
    }
}
