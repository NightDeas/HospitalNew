using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal class ContextFactory : DbContextFactory<Context>
    {
        public ContextFactory(IServiceProvider serviceProvider, DbContextOptions<Context> options, IDbContextFactorySource<Context> factorySource) : base(serviceProvider, options, factorySource)
        {
            
        }
    }
}
