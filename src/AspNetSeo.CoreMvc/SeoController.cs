using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSeo.CoreMvc
{
    public abstract class SeoController : Controller
    {
        private readonly Lazy<ISeoHelper> seoLazy;

        public ISeoHelper Seo => seoLazy.Value;

        protected SeoController(HttpContext context)
        {
            seoLazy = new Lazy<ISeoHelper>(this.GetSeoHelper(context));
        }
    }
}