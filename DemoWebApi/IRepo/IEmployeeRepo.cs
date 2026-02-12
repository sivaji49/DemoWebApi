using EEMS.Models;

namespace EEMS.IRepo
{
    public interface IEmployeeRepo
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> AddAsync(User emp);
        Task<User> UpdateAsync(User emp);
        Task<bool> DeleteAsync(int id);
    }
}
