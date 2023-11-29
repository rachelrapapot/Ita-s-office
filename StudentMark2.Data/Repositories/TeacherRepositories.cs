using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentsMark2;
using studentsMark2.Core.Repositories;


namespace studentsMark2.Data.Repositories
{
    public class TeacherRepositories: ITeacherRepositories
    {
            private readonly DataContext _context;

            public TeacherRepositories(DataContext dataContext)
            {
                _context = dataContext;
            } 
            public List<Teacher> GetAllTeacher()
            {
                return _context.teachers;
            }

          
        
    }
}
