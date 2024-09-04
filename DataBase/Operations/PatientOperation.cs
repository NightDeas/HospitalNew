using DataBase.Entities;

using Hospital.Services.DataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Operations
{
    internal class PatientOperation : IDefaultOperationDbEntity<Entities.Patient>
    {
        Context Context = new();
        public async Task<int> AddAsync(Patient Entity)
        {
            Context.Patients.Add(Entity);
            await Context.SaveChangesAsync();
            return Entity.Id;
        }

        public Task DeleteAsync(Patient Entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Patient>> GetPatientsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Patient Entity)
        {
            throw new NotImplementedException();
        }
    }
}
