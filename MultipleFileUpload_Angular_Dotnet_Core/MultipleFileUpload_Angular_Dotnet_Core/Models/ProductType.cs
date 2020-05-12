using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleFileUpload_Angular_Dotnet_Core.Models
{
    public class ProductTypeDTO
    {
        public string ProductDescriptionName { get; set; }
        public string Volume { get; set; }

        //public ICollection<MyFiles> ProductImages { get; set; }
        public List<IFormFile> ProductImages { get; set; }


    }

    public class MyFiles
    {

        public ICollection<IFormFile> Files { get; set; }

    }
}
