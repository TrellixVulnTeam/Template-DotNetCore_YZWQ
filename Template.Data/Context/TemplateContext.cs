using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Data.Mappings;
using Template.Domain.Entities;

namespace Template.Data.Context
{
    public class TemplateContext : DbContext
    {
        public TemplateContext(DbContextOptions<TemplateContext> options)
            : base(options) { }

        #region "DBSets"
        public DbSet<User> User { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
