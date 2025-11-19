using Microsoft.Extensions.DependencyInjection;
using GoodPup.Service.Interface;
using GoodPup.Repository.Interface;
using GoodPup.Repository;

namespace GoodPup.Service
{
    public static class InitializationService
    {
        public static void InitializeDependencies(this IServiceCollection services)
        {
            services.AddTransient<IGoodPupService, GoodPupService>();
            services.AddTransient<IGoodPupRepository, GoodPupRepository>();
        }
    }
}
