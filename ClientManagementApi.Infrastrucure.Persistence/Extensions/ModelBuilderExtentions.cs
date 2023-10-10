using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Infrastrucure.Persistence.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void RegisterAllEntities<BaseModel>(this ModelBuilder modelBuilder, params Assembly[] assemblies)
        {
            IEnumerable<Type> types = assemblies.SelectMany(a => a.GetExportedTypes()).Where(c => c.IsClass && !c.IsAbstract && c.IsPublic &&
              typeof(BaseModel).IsAssignableFrom(c));
            foreach (Type type in types)
                modelBuilder.Entity(type);
        }
    }
}
