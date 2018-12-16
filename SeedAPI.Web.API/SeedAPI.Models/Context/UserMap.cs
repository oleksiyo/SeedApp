using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeedAPI.Models.Models;

namespace SeedAPI.Models.Context
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.ToTable("User");

            entityBuilder.Property(user => user.Id).HasColumnName("Id");
            entityBuilder.HasKey(user => user.Id);

            entityBuilder.Property(user => user.Name)
                .HasColumnName("Name")
                .HasMaxLength(255)
                .IsRequired();

        }
    }
}