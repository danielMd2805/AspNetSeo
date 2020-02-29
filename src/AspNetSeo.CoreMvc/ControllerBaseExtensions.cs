using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSeo.CoreMvc
{
    public static class ControllerBaseExtensions
    {
        public static ISeoHelper GetSeoHelper(this ControllerBase controller, HttpContext context)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));

            var serviceProvider = context.RequestServices;
            if (serviceProvider == null)
            {
                string message =
                    $"The {nameof(context.RequestServices)} of the provided {nameof(ControllerBase)} cannot be null.";
                throw new ArgumentOutOfRangeException(nameof(controller), message);
            }

            var seoHelper = serviceProvider.GetSeoHelper();
            return seoHelper;
        }
    }
}