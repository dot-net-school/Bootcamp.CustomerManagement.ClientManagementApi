using ClientManagementApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Infrastrucure.Persistence.Configuration
{
    public class ClientConfig:IEntityTypeConfiguration<Client>
    {

    }
}
