using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultipleFileUpload_Angular_Dotnet_Core.Models;

namespace MultipleFileUpload_Angular_Dotnet_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add([FromForm] ProductDTO userDTO)
        {

            //foreach (ProductTypeDTO product in userDTO.ProductTypes)
            //{

            //    foreach (IFormFile fileData in product.ProductImages)
            //    {
            //        var filename = fileData.FileName;
            //    }
            //    //foreach (MyFiles fileData in product.ProductImages)
            //    //{
            //    //    var qqq = fileData.Files;

            //    //    foreach (IFormFile f in qqq)
            //    //    {
            //    //        var filename = f.FileName;
            //    //    }
            //    //}
            //}
            return Ok();
           
        }
    }
}