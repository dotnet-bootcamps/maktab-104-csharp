using S40_AspNetCore_DI.Contracts;

namespace S40_AspNetCore_DI.Infrastructures;

public class StudentEfRepository : IStudentRepository
{
    public StudentEfRepository()
    {
            
    }


    public string GetStudentName(int studentCode, string b)
    {
        return "dbContext.Students.FirstOrDefault(f => f.StudentCode == studentCode).StudentName";
    }
}