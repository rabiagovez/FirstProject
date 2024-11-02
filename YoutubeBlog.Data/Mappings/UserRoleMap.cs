using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("897010E5-B0C4-4776-8630-C4FCA38BFAD7"),
                RoleId = Guid.Parse("8DE3B7C6-5C8B-43CE-B764-1451667B4E5E")
            },new AppUserRole 
            {
               UserId = Guid.Parse("12EC1A48-7FAA-43A0-AFA3-E438928E5983"),
               RoleId = Guid.Parse("E59DB774-F8E0-49AF-A700-AB4DC816B6ED")
            });
        }
    }
}
