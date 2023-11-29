using studentsMark2.Core.Repositories;
using studentsMark2.Core.Services;
using studentsMark2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsMark2.servies
{
    public class TeacherServies: ITeacherServies
    {
        private readonly ITeacherRepositories _TeacherRepositories;
        public TeacherServies(ITeacherRepositories TeacherRepositories)
        {
            _TeacherRepositories = TeacherRepositories;
        }

        public List<Teacher> GetTeacher()
        {
            return _TeacherRepositories.GetAllTeacher();
        }

    
    }
}
