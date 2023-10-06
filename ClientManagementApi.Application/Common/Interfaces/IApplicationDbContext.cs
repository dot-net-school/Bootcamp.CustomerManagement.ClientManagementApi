using ClientManagementApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Degree> Degree { get; set; }
        public DbSet<Job> Job { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
