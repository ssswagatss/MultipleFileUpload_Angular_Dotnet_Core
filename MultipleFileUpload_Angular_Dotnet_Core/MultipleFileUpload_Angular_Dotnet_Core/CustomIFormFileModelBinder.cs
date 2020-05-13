using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MultipleFileUpload_Angular_Dotnet_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleFileUpload_Angular_Dotnet_Core
{
    public class CustomIFormFileModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
                throw new ArgumentNullException(nameof(bindingContext));

            if (bindingContext.ModelType != typeof(IEnumerable<AdritaFile>) && bindingContext.ModelType != typeof(AdritaFile))
                throw new ArgumentNullException(nameof(bindingContext));

            var modelName = bindingContext.ModelName;
            if (bindingContext.ModelType == typeof(IEnumerable<AdritaFile>))
            {
                if (bindingContext.HttpContext.Request.Form.Files.Any())
                {
                    var files = new List<AdritaFile>();
                    foreach (var f in bindingContext.HttpContext.Request.Form.Files.Where(x => x.Name.StartsWith(modelName)))
                    {
                        var file = new AdritaFile
                        {
                            File = bindingContext.HttpContext.Request.Form.Files[f.Name]
                        };
                        files.Add(file);
                    }

                    bindingContext.Result = ModelBindingResult.Success(files);
                }
            }
            else if (bindingContext.ModelType == typeof(AdritaFile))
            {
                var file = new AdritaFile
                {
                    File = bindingContext.HttpContext.Request.Form.Files[modelName]
                };
                bindingContext.Result = ModelBindingResult.Success(file);
            }

            return Task.CompletedTask;
        }
    }
}
