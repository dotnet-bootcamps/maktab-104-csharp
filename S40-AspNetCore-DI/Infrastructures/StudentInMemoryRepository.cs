using S40_AspNetCore_DI.Contracts;
using S40_AspNetCore_DI.Models;

namespace S40_AspNetCore_DI.Infrastructures
{
    public class StudentInMemoryRepository : IStudentRepository
    {
        private List<Student> _students = new List<Student>()
        {
            new Student{StudentCode = 1, StudentName = "Salman"},
            new Student{StudentCode = 2, StudentName = "Hassan"},
            new Student{StudentCode = 3, StudentName = "Ali"},
            new Student{StudentCode = 4, StudentName = "Yaser"},
            new Student{StudentCode = 5, StudentName = "Zahra"},
        };
        public string GetStudentName(int studentCode, string b)
        {
            return _students.FirstOrDefault(f => f.StudentCode == studentCode).StudentName;
        }
    }
}
