using ClientManagementApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Application.Common
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        /// <summary>
        /// Save all entities in to database.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<SaveChangesResult> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        public DbSet<Client> Clients { get; }
    }
}
