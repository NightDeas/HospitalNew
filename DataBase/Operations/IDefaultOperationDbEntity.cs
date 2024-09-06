using DataBase.Entities;

namespace DataBase.Operations
{
    public interface IDefaultOperationDbEntity<T>
    {
        Task<List<T>> GetPatientsAsync();
        Task<int> AddAsync(T Entity);
        Task UpdateAsync(T Entity);
        Task DeleteAsync(T Entity);
        Task DeleteAsync(int id);

    }
}
