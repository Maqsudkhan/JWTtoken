using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessageEmail.Domain.Enum
{
    public enum Permission
    {
        CreateStudent = 1,
        UpdateStudent = 2,
        GetStudentByID = 3,
        GetAllStudent = 4,
        DeleteStudent = 5,
        GetAllTeacher = 6,
        GetTeacherById = 7,
        CreateTeacher = 8,
        DeleteTeacher = 9,
        UpdateTeacher = 10,
    }
}
