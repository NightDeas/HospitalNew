using DataBase.Entities;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Operations
{
	internal class GenreOperationService : IDefaultOperationDbEntity<DataBase.Entities.Genre>
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

		public async Task<List<Genre>> GetAll()
		{

		}

		public Task UpdateAsync(Genre Entity)
		{
			throw new NotImplementedException();
		}
	}
}
