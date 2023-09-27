using Microsoft.AspNetCore.Mvc.ModelBinding;
using Model.Classes;
using Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Services
{
    public class MessageBinder : IModelBinder
    {
        private readonly MessageContext messageContext;

        public MessageBinder(MessageContext messageContext)
        {
            this.messageContext = messageContext;
        }

        public async Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var modelName = bindingContext.ModelName;

            // Try to fetch the value of the argument by name
            var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);

            if (valueProviderResult == ValueProviderResult.None)
            {
                return;
            }

            bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);

            var value = valueProviderResult.FirstValue;

            // Check if the argument value is null or empty
            if (string.IsNullOrEmpty(value))
            {
                return;
            }

            //if (!int.TryParse(value, out var id))
            //{
            //    // Non-integer arguments result in model state errors
            //    bindingContext.ModelState.TryAddModelError(
            //        modelName, "Message Id must be a string.");

            //    return Task.CompletedTask;
            //}

            // Model will be null if not found, including for
            // out of range id values (0, -3, etc.)
            var model = await messageContext.ReadAsync(value /* id */);
            bindingContext.Result = ModelBindingResult.Success(model);
            return;
        }
    }
}
