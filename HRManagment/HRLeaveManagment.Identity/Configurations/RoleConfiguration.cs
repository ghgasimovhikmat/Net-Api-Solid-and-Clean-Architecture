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
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "4b724c59-76b9-4f87-bf4c-82349758d8f2",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                 new IdentityRole
                 {
                     Id ="284e293b-a6ba-48d5-a175-833683de4e2f",
                     Name = "Adminstrator",
                     NormalizedName = "ADMINSTRATOR"
                 }
                );
        }
    }
}
