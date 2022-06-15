using Microsoft.EntityFrameworkCore;
using WebProject.API.DataModels;
using WebProject.API.Repositories;

namespace WebProject.API.Services;

public class SqlStudentService : IStudentRepository
{
    private readonly StudentAdminContext _context;

    public SqlStudentService(StudentAdminContext context)
    {
        _context = context;
    }
    public async Task<List<Student>> GetStudentsAsync()
    {
       return await _context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
    }

    public async Task<Student> GetStudentAsync(Guid studentId)
    {
        return await _context.Student
            .Include(nameof(Gender)).Include(nameof(Address))
            .FirstOrDefaultAsync(x => x.Id == studentId);
    }

    public async Task<List<Gender>> GetGendersListAsync()
    {
        return await _context.Gender.ToListAsync();
    }
}