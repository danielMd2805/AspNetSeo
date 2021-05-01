using System;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSeo.CoreMvc
{
    public abstract class SeoController : Controller
    {
        #region Public Properties

        public ISeoHelper Seo => seoLazy.Value;

        #endregion Public Properties

        #region Protected Constructors

        protected SeoController(HttpContext context)
        {
            seoLazy = new Lazy<ISeoHelper>(() => this.GetSeoHelper(context));
        }

        #endregion Protected Constructors

        #region Private Fields

        private readonly Lazy<ISeoHelper> seoLazy;

        #endregion Private Fields
    }
}
