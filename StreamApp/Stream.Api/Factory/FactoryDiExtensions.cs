using Microsoft.Extensions.DependencyInjection.Extensions;
using Stream.Api.Services;

namespace Stream.Api.Factory
{
    public static class FactoryDiExtensions
    {
        public static IServiceCollection RegisterScopedService<TImplementation>(this IServiceCollection services, string name)
            where TImplementation : class, IStreamService
        {
            services.TryAddScoped<StreamFactory>();
            services.TryAddScoped<TImplementation>();
            services.Configure<StreamFactoryOptions>(options => options.Register<TImplementation>(name));
            return services;
        }
    }
}
