using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBCodeFirst.Projects
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable(nameof(Project)).HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectId).HasColumnName(nameof(Project.ProjectId)).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasColumnName(nameof(Project.Name)).IsRequired();
            builder.Property(p => p.Budget).HasColumnName(nameof(Project.Budget)).IsRequired();
            builder.Property(p => p.StartedDate).HasColumnName(nameof(Project.StartedDate)).IsRequired();
        }
    }
}
