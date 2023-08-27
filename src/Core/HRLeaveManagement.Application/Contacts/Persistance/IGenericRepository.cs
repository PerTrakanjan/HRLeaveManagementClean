namespace HRLeaveManagement.Application;

public interface IGenericRepository<T> : where T : class
{
    Task<T> GetAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> CreateAsync(int id);
    Task<T> UpdateAsync(int id);
    Task<T> DeleteIdAsync(int id);
}





