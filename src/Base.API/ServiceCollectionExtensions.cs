using Base.Domain.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Web;

namespace Base.API
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPrifileContext(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IProfileContext>((provider) =>
            {
                var accessor = provider.GetService<IHttpContextAccessor>();
                var userIdStr = accessor?.HttpContext?.Request?.Headers["UserId"];
                var userNameStr = accessor?.HttpContext?.Request?.Headers["Username"];
                var tenantIdStr = accessor?.HttpContext?.Request?.Headers["TenantId"];
                var identityIdStr = accessor?.HttpContext?.Request?.Headers["IdentityId"];
                var uuidStr = accessor?.HttpContext?.Request?.Headers["UUID"];
                long userId = 0;
                long tenantId = 0;
                long identityId = 0;
                long.TryParse(userIdStr, out userId);
                long.TryParse(tenantIdStr, out tenantId);
                long.TryParse(identityIdStr, out identityId);
                if (!string.IsNullOrWhiteSpace(userNameStr))
                {
                    userNameStr = HttpUtility.UrlDecode(userNameStr);
                }
                var context = new ProfileContext(identityId, userId, userNameStr, tenantId, "");
                context.Properties.Add("UUID", uuidStr);
                return context;
            });

            return services;
        }

    }
}
