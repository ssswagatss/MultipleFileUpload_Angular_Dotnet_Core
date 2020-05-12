using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleFileUpload_Angular_Dotnet_Core.Models
{
    public class ProductDTO
    {
        public string ProductName { get; set; }
        public ProductTypeDTO ProductTypes { get; set; }

    }
}
