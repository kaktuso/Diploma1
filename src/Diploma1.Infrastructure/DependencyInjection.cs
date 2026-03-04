using Microsoft.Extensions.DependencyInjection;
using Diploma1.Infrastructure.Persistence;
using Diploma1.Infrastructure.Repositories;
using Diploma1.Infrastructure.UnitOfWork;
using Diploma1.Domain.Interfaces;
using Diploma1.Application.Interfaces;
using Diploma1.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace Diploma1.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IWorkplaceRepository, WorkplaceRepository>();
            services.AddScoped<IAttestationRepository, AttestationRepository>();
            services.AddScoped<IRegulatoryDocumentRepository, RegulatoryDocumentRepository>();
            services.AddScoped<IMonitoringRecordRepository, MonitoringRecordRepository>();
            services.AddScoped<IUnitOfWork, Diploma1.Infrastructure.UnitOfWork.UnitOfWork>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IWorkplaceService, WorkplaceService>();
            services.AddScoped<IAttestationService, AttestationService>();
            services.AddScoped<IRegulatoryDocumentService, RegulatoryDocumentService>();
            services.AddScoped<IMonitoringService, MonitoringService>();
            // TODO: Add other services
            return services;
        }
    }
}