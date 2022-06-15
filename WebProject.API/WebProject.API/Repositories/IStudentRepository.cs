
using WebProject.API.DataModels;

namespace WebProject.API.Repositories;

public interface IStudentRepository
{
    Task<List<Student>> GetStudentsAsync();
    Task<Student> GetStudentAsync(Guid studentId);

    Task<List<Gender>> GetGendersListAsync();
}