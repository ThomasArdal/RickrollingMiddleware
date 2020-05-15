using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace RickrollingMiddleware
{
    public class RedirectInvalidUrlsMiddleware
    {
        private readonly RequestDelegate _next;

        public RedirectInvalidUrlsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.IsInvalid())
            {
                context.Response.Redirect("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                return;
            }

            await _next(context);
        }
    }
}
