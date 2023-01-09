using DBCodeFirst.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCodeFirst.EmployeeProjects
{
    internal class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable(nameof(EmployeeProject)).HasKey(p => p.EmployeeProjectId);
            builder.Property(p => p.EmployeeProjectId).HasColumnName(nameof(EmployeeProject.EmployeeProjectId)).ValueGeneratedOnAdd();
            builder.Property(p => p.StarteDate).HasColumnName(nameof(EmployeeProject.StarteDate)).IsRequired();
            builder.Property(p => p.EmployeeId).HasColumnName(nameof(EmployeeProject.EmployeeId)).IsRequired();
            builder.Property(p => p.ProjectId).HasColumnName(nameof(EmployeeProject.ProjectId)).IsRequired();
        }
    }
}
