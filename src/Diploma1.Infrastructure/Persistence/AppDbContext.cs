using Microsoft.EntityFrameworkCore;
using Diploma1.Domain.Entities;

namespace Diploma1.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Workplace> Workplaces => Set<Workplace>();
        public DbSet<Attestation> Attestations => Set<Attestation>();
        public DbSet<RegulatoryDocument> RegulatoryDocuments => Set<RegulatoryDocument>();
        public DbSet<MonitoringRecord> MonitoringRecords => Set<MonitoringRecord>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Attestation.Employee (основной сотрудник)
            modelBuilder.Entity<Attestation>()
                .HasOne(a => a.Employee)
                .WithMany(e => e.Attestations)
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Attestation.ResponsibleEngineer (ответственный инженер)
            modelBuilder.Entity<Attestation>()
                .HasOne(a => a.ResponsibleEngineer)
                .WithMany()
                .HasForeignKey(a => a.ResponsibleEngineerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee.Department
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee.Workplace
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Workplace)
                .WithMany(w => w.Employees)
                .HasForeignKey(e => e.WorkplaceId)
                .OnDelete(DeleteBehavior.Restrict);

            // Workplace.Department
            modelBuilder.Entity<Workplace>()
                .HasOne(w => w.Department)
                .WithMany(d => d.Workplaces)
                .HasForeignKey(w => w.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // MonitoringRecord.Employee
            modelBuilder.Entity<MonitoringRecord>()
                .HasOne(m => m.Employee)
                .WithMany(e => e.MonitoringRecords)
                .HasForeignKey(m => m.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Value Objects (Owned Entities)
            modelBuilder.Entity<Employee>().OwnsOne(e => e.Email);
            modelBuilder.Entity<Employee>().OwnsOne(e => e.FullName);
        }
    }
}