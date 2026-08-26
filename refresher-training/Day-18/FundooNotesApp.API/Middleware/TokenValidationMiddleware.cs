using FundooNotesApp.BusinessLayer.Helper;

namespace FundooNotesApp.API.Middleware
{
    public class TokenValidationMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenValidationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, RedisCacheHelper cache)
        {
            if (context.User.Identity?.IsAuthenticated == true)
            {
                var userId = context.User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
                var authHeader = context.Request.Headers["Authorization"].ToString();
                var incomingToken = authHeader.Replace("Bearer ", "");

                // check the token is still active in Redis, rejects logged-out tokens
                var cachedToken = cache.GetToken($"user_token:{userId}");
                if (cachedToken == null || cachedToken != incomingToken)
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsync("Session expired or logged out");
                    return;
                }
            }

            await _next(context);
        }
    }
}