using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using MultipleFileUpload_Angular_Dotnet_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleFileUpload_Angular_Dotnet_Core
{
    public class CustomIFormFileModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(IEnumerable<AdritaFile>))
            {
                return new BinderTypeModelBinder(typeof(CustomIFormFileModelBinder));
            }
            if (context.Metadata.ModelType == typeof(AdritaFile))
            {
                return new BinderTypeModelBinder(typeof(CustomIFormFileModelBinder));
            }
            return null;
        }
    }
}
