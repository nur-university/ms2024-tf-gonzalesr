using Microsoft.Extensions.DependencyInjection;
using PatientManagement.Domain.Transactions;
using PatientManagement.Domain.Patients;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddMediatR(config =>
                config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())
            );


            services.AddSingleton<IPatientFactory, PatientFactory>();


            return services;
        }

    }
}
