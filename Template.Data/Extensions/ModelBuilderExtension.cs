using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Entities;

namespace Template.Data.Extensions
{
   public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User { Id = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"), Name = "User Default", Email = "userdefault@template.com"}
                );
            return builder;   
        }
    }
}
