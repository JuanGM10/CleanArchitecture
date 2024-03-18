using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                    new ApplicationUser
                    {
                        Id = "f284b3fd-f2cf-476e-a9b6-6560689cc48c",
                        Email = "admin@locahost.com",
                        NormalizedEmail = "admin@locahost.com",
                        Nombre = "Juan Luis",
                        Apellidos = "Guerra Meneses",
                        UserName = "jamuisAdmin",
                        NormalizedUserName = "jamuisAdmin",
                        PasswordHash = hasher.HashPassword(null, "jamuisAdmin2024"),
                        EmailConfirmed = true,
                    },
                    new ApplicationUser
                    {
                        Id = "294d249b-9b57-48c1-9689-11a91abb6447",
                        Email = "luisguerra.jlgm@gmail.com",
                        NormalizedEmail = "luisguerra.jlgm@gmail.com",
                        Nombre = "Juan Luis",
                        Apellidos = "Guerra Meneses",
                        UserName = "jamuis",
                        NormalizedUserName = "jamuis",
                        PasswordHash = hasher.HashPassword(null, "T3aw0@l414_2025$"),
                        EmailConfirmed = true,
                    }

                );


        }
    }
}
