using DataBase.Entities;

namespace Hospital.Services.DataBase
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
