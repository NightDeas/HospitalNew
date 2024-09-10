using DataBase.Entities;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Operations
{
	public class GenreOperationService : IDefaultOperationDbEntity<DataBase.Entities.Genre>
	{
		Context context = new();

		public Task<int> AddAsync(Genre Entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(Genre Entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Genre> Get(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<Genre>> GetAll()
		{
			return context.Genres.ToListAsync();
		}

		public Task UpdateAsync(Genre Entity)
		{
			throw new NotImplementedException();
		}
	}
}
