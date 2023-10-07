using ClientManagementApi.Domain.Common;
using ClientManagementApi.Infrastrucure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Infrastrucure.Persistence
{
    public partial class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var entitiesAssemblyInt = typeof(BaseEntity<int>).Assembly;
            var entitiesAssemblyGuid = typeof(BaseEntity<Guid>).Assembly;
            modelBuilder.RegisterAllEntities<BaseEntity<int>>(entitiesAssemblyInt);
            modelBuilder.RegisterAllEntities<BaseEntity<Guid>>(entitiesAssemblyGuid);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
