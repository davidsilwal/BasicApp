using Microsoft.Extensions.DependencyInjection;

namespace SharedKernel.Application.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddBasicServiceExtensions(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
    }
}
