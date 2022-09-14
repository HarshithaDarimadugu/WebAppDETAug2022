using ODataDemo.Api.Models;

namespace ODataDemo.Api.Services
{
    public interface IStudentService
    {
        IQueryable<Student> RetrieveAllStudents();
    }
}
