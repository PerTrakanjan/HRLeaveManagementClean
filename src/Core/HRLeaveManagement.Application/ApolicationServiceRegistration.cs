using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application
{
    public static class ApolicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ApolicationServiceRegistration));
            services.AddMediatR(
                config => config.RegisterSerivcesFromAssembly(Assembly.GetExecutingAssembly())
            );

            return services;
        }
    }
}