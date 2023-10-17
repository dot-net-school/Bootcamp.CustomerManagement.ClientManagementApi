using ClientManagementApi.Application.Common.Interfaces;
using ClientManagementApi.Domain.Common;
using ClientManagementApi.Domain.Entities;
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
    public partial class ApplicationDbContext : DbContext, IApplicationDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        //public DbSet<Client> Client { get; set; }
        //public DbSet<Address> Address { get; set; }
        //public DbSet<Degree> Degree { get; set; }
        //public DbSet<Job> Job { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            modelBuilder.RegisterAllEntities(typeof(EntityAttribute).Assembly);
        
        }
        public new DbSet<TEntity> Set<TEntity>() where TEntity : class 
            => base.Set<TEntity>();

    }
}
