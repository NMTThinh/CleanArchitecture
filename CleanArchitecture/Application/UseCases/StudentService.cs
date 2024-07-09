using Application.Interfaces;
using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return _studentRepository.GetAllStudentsAsync();
        }

        public Task<Student> GetStudentByIdAsync(int id)
        {
            return _studentRepository.GetStudentByIdAsync(id);
        }

        public Task AddStudentAsync(Student student)
        {
            return _studentRepository.AddStudentAsync(student);
        }

        public Task UpdateStudentAsync(Student student)
        {
            return _studentRepository.UpdateStudentAsync(student);
        }

        public Task DeleteStudentAsync(int id)
        {
            return _studentRepository.DeleteStudentAsync(id);
        }
    }
}
