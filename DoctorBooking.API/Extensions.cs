using Microsoft.Extensions.DependencyInjection;
using Notification.Shared;

namespace Notification.API
{
    public static class Extensions
    {
        public static IServiceCollection AddNotificationsModule(this IServiceCollection services)
        {
            services.AddScoped<INotificationsModuleApi, NotificationsModuleApi>();

            return services;
        }
    }
}
