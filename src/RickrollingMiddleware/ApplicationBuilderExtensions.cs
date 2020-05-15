using RickrollingMiddleware;
using System;

namespace Microsoft.AspNetCore.Builder
{
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Adds a middleware to the ASP.NET Core pipeline that rick roll users requesting an invalid URL.
        /// </summary>
        public static IApplicationBuilder UseRickrolling(this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));

            return app.UseMiddleware<RedirectInvalidUrlsMiddleware>();
        }
    }
}
