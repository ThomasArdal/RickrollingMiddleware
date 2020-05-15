using Microsoft.AspNetCore.Http;
using System;

namespace RickrollingMiddleware
{
    internal static class InvalidUrlExtensions
    {
        internal static bool IsInvalid(this HttpRequest httpRequest)
        {
            if (httpRequest == null) return false;
            if (!httpRequest.Path.HasValue) return false;
            var path = httpRequest.Path.Value;
            if (string.IsNullOrWhiteSpace(path)) return false;

            if (path.Equals("/.env", StringComparison.InvariantCultureIgnoreCase)) return true;
            if (path.Equals("/wp-login.php", StringComparison.InvariantCultureIgnoreCase)) return true;
            if (path.Equals("/wp-admin", StringComparison.InvariantCultureIgnoreCase)) return true;

            return false;
        }
    }
}
