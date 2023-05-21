using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagment.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<string>> builder)
        {
            builder.HasData(
               new IdentityUserRole<string>
               {
                   RoleId = "284e293b-a6ba-48d5-a175-833683de4e2f",
                   UserId = "fd1ea69f-09ee-4c3d-96a4-9e6c683120f1"

               },
                new IdentityUserRole<string>
                {
                    RoleId = "4b724c59-76b9-4f87-bf4c-82349758d8f2",
                    UserId = "49aa6ae7-edc9-469f-a73d-14473b9d7e0e",
                });
        }
    }
}
