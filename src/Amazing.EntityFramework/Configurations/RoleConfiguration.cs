using Amazing.Authorization.Roles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Amazing.EntityFramework.Configurations
{
    class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Name).HasMaxLength(Role.Constants.MaxNameLength);
            builder.Property(p => p.NormalizedName).HasMaxLength(Role.Constants.MaxNormalizedNameLength);
            builder.Property(p => p.DisplayName).HasMaxLength(Role.Constants.MaxDisplayNameLength);
            builder.Property(p => p.Description).HasMaxLength(Role.Constants.MaxDescriptionLength);
        }
    }
}
