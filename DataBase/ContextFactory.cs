using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
		public Context CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<Context>();
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-3VRB7GU;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
			return new Context(optionsBuilder.Options);
		}
	}
}
