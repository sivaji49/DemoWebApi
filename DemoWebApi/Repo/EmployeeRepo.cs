using EEMS.DbContextModels;
using EEMS.IRepo;
using EEMS.Models;
using Microsoft.EntityFrameworkCore;

namespace EEMS.Repo
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
            => await _context.Users.Include(u => u.RoleId)
                                   .Include(u => u.DepartmentId)
                                   .ToListAsync();

        public async Task<User> GetByIdAsync(int id)
            => await _context.Users.Include(u => u.RoleId)
                                   .Include(u => u.DepartmentId)
                                   .FirstOrDefaultAsync(u => u.Id == id);

        public async Task<User> AddAsync(User emp)
        {
            _context.Users.Add(emp);
            await _context.SaveChangesAsync();
            return emp;
        }

        public async Task<User> UpdateAsync(User emp)
        {
            _context.Users.Update(emp);
            await _context.SaveChangesAsync();
            return emp;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var emp = await _context.Users.FindAsync(id);
            if (emp == null) return false;
            _context.Users.Remove(emp);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
