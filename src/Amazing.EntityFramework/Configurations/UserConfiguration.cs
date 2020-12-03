using Amazing.Authorization.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Amazing.EntityFramework.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.UserName).HasMaxLength(User.Constants.MaxUserNameLength);
            builder.Property(p => p.NormalizedUserName).HasMaxLength(User.Constants.MaxNormalizedUserNameLength);
            builder.Property(p => p.Email).HasMaxLength(User.Constants.MaxEmailLength);
            builder.Property(p => p.NormalizedEmail).HasMaxLength(User.Constants.MaxNormalizedEmailLength);
            builder.Property(p => p.PasswordHash).HasMaxLength(User.Constants.MaxPasswordHashLength);
            builder.Property(p => p.PhoneNumber).HasMaxLength(User.Constants.MaxPhoneNumberLength);
            builder.Property(p => p.Name).HasMaxLength(User.Constants.MaxNameLength);
            builder.Property(p => p.Surname).HasMaxLength(User.Constants.MaxSurnameLength);
            builder.Property(p => p.Photo).HasMaxLength(User.Constants.MaxPhotoLength);
        }
    }
}
