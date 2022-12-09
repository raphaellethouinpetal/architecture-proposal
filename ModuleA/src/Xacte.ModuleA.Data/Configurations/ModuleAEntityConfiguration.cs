using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Xacte.ModuleA.Data.Entities;

namespace Xacte.ModuleA.Data.Configurations
{
    internal sealed class ModuleAEntityConfiguration : IEntityTypeConfiguration<ModuleAEntity>
    {
        public void Configure(EntityTypeBuilder<ModuleAEntity> builder)
        {
            builder.HasIndex(i => i.Guid)
                .IsUnique(true);

            builder.Property(p => p.MyProperty)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.WhatsUpWithThatName)
                .HasColumnName("What_s_Up_with_THAT_name");
        }
    }
}
